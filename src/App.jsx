import React, { useState, useEffect, useCallback } from 'react';
import { History, Volume2, Trash2, X, Clipboard, RotateCcw, Mail, User, Calendar, ExternalLink } from 'lucide-react';
import confetti from 'canvas-confetti';

const units = {
  en: ["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"],
  es: ["cero", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve", "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve"],
  fr: ["zéro", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix", "onze", "douze", "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf"],
  ar: ["صفر", "واحد", "اثنان", "ثلاثة", "أربعة", "خمسة", "ستة", "سبعة", "ثمانية", "تسعة", "عشرة", "أحد عشر", "اثنا عشر", "ثلاثة عشر", "أربعة عشر", "خمسة عشر", "ستة عشر", "سبعة عشر", "ثمانية عشر", "تسعة عشر"],
  yo: ["odo", "okan", "eji", "eta", "erin", "arun", "efa", "eje", "ejo", "esan", "ewa", "okanla", "ejila", "etala", "erinla", "edogun", "erindinlogun", "etadinlogun", "ejidinlogun", "okandinlogun"]
};

const tens = {
  en: ["", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"],
  es: ["", "diez", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa"],
  fr: ["", "dix", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante-dix", "quatre-vingt", "quatre-vingt-dix"],
  ar: ["", "عشرة", "عشرون", "ثلاثون", "أربعون", "خمسون", "ستون", "سبعون", "ثمانون", "تسعون"],
  yo: ["", "ewa", "ogun", "ogbon", "ogoji", "aadota", "ogota", "aadarin", "ogorin", "aadoun"]
};

const scales = {
  en: ["", "thousand", "million", "billion", "trillion"],
  es: ["", "mil", "millón", "mil millones", "billón"],
  fr: ["", "mille", "million", "milliard", "billion"],
  ar: ["", "ألف", "مليون", "مليار", "تريليون"],
  yo: ["", "egberun", "miliọnu", "bilionu", "tirilionu"]
};

const numberToWords = (num, lang = 'en') => {
  if (num === 0) return units[lang][0];
  if (num < 0) {
    const prefix = lang === 'en' ? 'minus ' : lang === 'es' ? 'menos ' : lang === 'fr' ? 'moins ' : lang === 'ar' ? 'سالب ' : 'minus ';
    return prefix + numberToWords(Math.abs(num), lang);
  }

  let words = '';
  
  const processHundreds = (n, l) => {
    let str = '';
    if (n >= 100) {
      if (l === 'es' && n === 100) return 'cien';
      if (l === 'fr' && Math.floor(n/100) > 1) {
        str += units[l][Math.floor(n/100)] + ' cent';
        if (n % 100 === 0) str += 's';
      } else if (l === 'ar') {
        const h = Math.floor(n/100);
        if (h === 1) str += 'مئة';
        else if (h === 2) str += 'مئتان';
        else str += units[l][h].replace('ة', '') + 'مئة';
      } else {
        str += (Math.floor(n/100) > 1 || l !== 'es' ? units[l][Math.floor(n/100)] + ' ' : '') + (l === 'es' && Math.floor(n/100) === 1 ? 'ciento' : l === 'fr' ? 'cent' : l === 'yo' ? 'ogoruun' : 'hundred');
      }
      n %= 100;
      if (n > 0) str += (l === 'ar' ? ' و ' : ' ');
    }
    if (n > 0) {
      if (n < 20) str += units[l][n];
      else {
        if (l === 'ar') {
          str += (n % 10 > 0 ? units[l][n % 10] + ' و ' : '') + tens[l][Math.floor(n/10)];
        } else {
          str += tens[l][Math.floor(n/10)];
          if (n % 10 > 0) {
            str += (l === 'en' ? '-' : l === 'es' ? ' y ' : l === 'yo' ? ' le ' : '-') + units[l][n % 10];
          }
        }
      }
    }
    return str.trim();
  };

  let chunkCount = 0;
  while (num > 0) {
    let chunk = num % 1000;
    if (chunk > 0) {
      let chunkWords = processHundreds(chunk, lang);
      let scale = scales[lang][chunkCount];
      
      if (lang === 'es' && chunk === 1 && chunkCount === 1) chunkWords = ''; 
      if (lang === 'fr' && chunk === 1 && chunkCount === 1) chunkWords = '';
      if (lang === 'ar') {
        if (chunk === 1 && chunkCount === 1) chunkWords = 'ألف';
        else if (chunk === 2 && chunkCount === 1) chunkWords = 'ألفان';
        else if (chunk >= 3 && chunk <= 10 && chunkCount === 1) scale = 'آلاف';
      }
      
      const connector = (lang === 'ar' && words) ? ' و ' : (words ? ' ' : '');
      words = chunkWords + (scale && chunkWords !== 'ألف' && chunkWords !== 'ألفان' ? ' ' + scale : (chunkWords === 'ألف' || chunkWords === 'ألفان' ? '' : '')) + connector + words;
    }
    num = Math.floor(num / 1000);
    chunkCount++;
  }

  return words.trim();
};

export default function App() {
  const [input, setInput] = useState('0');
  const [result, setResult] = useState('');
  const [words, setWords] = useState('zero');
  const [lang, setLang] = useState('en');
  const [isHistoryOpen, setIsHistoryOpen] = useState(false);
  const [history, setHistory] = useState([]);

  useEffect(() => {
    const val = parseFloat(result || input);
    if (!isNaN(val)) {
      setWords(numberToWords(Math.floor(val), lang));
    }
  }, [input, result, lang]);

  const handleNumber = (n) => {
    if (input === '0') setInput(n.toString());
    else setInput(input + n);
    setResult('');
  };

  const handleOperator = (op) => {
    if (input === '0' && op === '-') {
      setInput('-');
      return;
    }
    if (/[+\-*/% ] ?$/.test(input)) {
        setInput(input.trim().slice(0, -1) + ' ' + op + ' ');
    } else {
        setInput(input + ' ' + op + ' ');
    }
    setResult('');
  };

  const calculate = () => {
    try {
      // Basic evaluation (using Function for safety over eval in this controlled context)
      const res = Function('"use strict";return (' + input.replace('X', '*') + ')')();
      const roundedRes = Math.round(res * 100) / 100;
      setResult(roundedRes.toString());
      
      const newEntry = {
        expression: input,
        result: roundedRes,
        words: numberToWords(Math.floor(roundedRes), lang),
        timestamp: new Date().toLocaleTimeString()
      };
      
      setHistory([newEntry, ...history].slice(0, 20));
      setInput(roundedRes.toString());

      if (roundedRes > 1000) {
        confetti({
          particleCount: 100,
          spread: 70,
          origin: { y: 0.6 },
          colors: ['#6366f1', '#10b981', '#f8fafc']
        });
      }
    } catch (e) {
      setResult('Error');
    }
  };

  const clear = () => {
    setInput('0');
    setResult('');
    setWords('zero');
  };

  const speak = () => {
    const utterance = new SpeechSynthesisUtterance(words);
    const voices = {
      en: 'en-US',
      es: 'es-ES',
      fr: 'fr-FR',
      ar: 'ar-SA',
      yo: 'en-GB' // Yoruba often falls back to English voice if not available, or system specific
    };
    utterance.lang = voices[lang] || 'en-US';
    window.speechSynthesis.speak(utterance);
  };

  const copyToClipboard = () => {
    navigator.clipboard.writeText(`${result || input} - ${words}`);
  };

  return (
    <div className="calculator-container glass">
      <div className="controls-top">
        <select className="lang-selector" value={lang} onChange={(e) => setLang(e.target.value)}>
          <option value="en">English (EN)</option>
          <option value="es">Español (ES)</option>
          <option value="fr">Français (FR)</option>
          <option value="ar">العربية (AR)</option>
          <option value="yo">Yorùbá (YO)</option>
        </select>
        <div style={{ display: 'flex', gap: '8px' }}>
          <button className="icon-btn" onClick={copyToClipboard} title="Copy result"><Clipboard size={18} /></button>
          <button className="icon-btn" onClick={speak} title="Read aloud"><Volume2 size={18} /></button>
          <button className="icon-btn" onClick={() => setIsHistoryOpen(true)} title="History"><History size={18} /></button>
        </div>
      </div>

      <div className={`display ${lang === 'ar' ? 'rtl' : ''}`}>
        <div className="input-text">{input}</div>
        <div className="result-text">{result || input}</div>
        <div className="words-text">{words}</div>
      </div>

      <div className="keypad">
        <button className="operator clear" onClick={clear}>AC</button>
        <button className="operator" onClick={() => handleOperator('%')}>%</button>
        <button className="operator" onClick={() => handleOperator('/')}>÷</button>
        <button className="operator" onClick={() => handleOperator('*')}>×</button>

        {[7, 8, 9].map(n => <button key={n} onClick={() => handleNumber(n)}>{n}</button>)}
        <button className="operator" onClick={() => handleOperator('-')}>−</button>

        {[4, 5, 6].map(n => <button key={n} onClick={() => handleNumber(n)}>{n}</button>)}
        <button className="operator" onClick={() => handleOperator('+')}>+</button>

        {[1, 2, 3].map(n => <button key={n} onClick={() => handleNumber(n)}>{n}</button>)}
        <button key="dot" onClick={() => { 
          const lastPart = input.split(/[+\-*/%]/).pop();
          if(!lastPart.includes('.')) setInput(input + '.') 
        }}>.</button>

        <button onClick={() => handleNumber(0)}>0</button>
        <button className="equals" onClick={calculate}>=</button>
      </div>

      <div className={`history-panel ${isHistoryOpen ? 'open' : ''}`}>
        <div className="history-header">
          <h3>History</h3>
          <button className="icon-btn" onClick={() => setIsHistoryOpen(false)}><X size={20} /></button>
        </div>
        <div className="history-list">
          {history.length === 0 && <p style={{ color: 'var(--text-secondary)', textAlign: 'center', marginTop: '40px' }}>No history yet</p>}
          {history.map((item, i) => (
            <div key={i} className="history-item">
              <div className="eq">{item.expression} =</div>
              <div className="res">{item.result}</div>
              <div className="wrd">{item.words}</div>
              <div style={{ fontSize: '0.6rem', color: 'var(--text-secondary)', marginTop: '4px' }}>{item.timestamp}</div>
            </div>
          ))}
          {history.length > 0 && (
            <button 
              onClick={() => setHistory([])}
              style={{ background: 'transparent', border: 'none', color: '#ef4444', fontSize: '0.9rem', marginTop: '12px' }}
            >
              Clear History
            </button>
          )}
        </div>
      </div>

      <footer className="author-footer">
        <div className="footer-line"></div>
        <div className="author-info">
          <div className="author-name">
            <User size={14} className="icon" />
            <span>Developer: <strong>Idowu Ojikutu</strong></span>
          </div>
          <div className="author-year">
            <Calendar size={14} className="icon" />
            <span>{new Date().getFullYear()}</span>
          </div>
        </div>
        <div className="contact-info">
          <div className="contact-label">For Collaboration & Gigs:</div>
          <a href="mailto:ojikutuidowu@yahoo.com" className="contact-link">
            <Mail size={14} className="icon" />
            <span>ojikutuidowu@yahoo.com</span>
            <ExternalLink size={12} className="external-icon" />
          </a>
        </div>
      </footer>
    </div>
  );
}
