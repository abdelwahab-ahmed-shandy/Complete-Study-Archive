<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>Information Disclosure : APPRENTICE : Source code disclosure via backup files</title><style>
      * {
        font-family: Georgia, Cambria, "Times New Roman", Times, serif;
      }
      html, body {
        margin: 0;
        padding: 0;
      }
      h1 {
        font-size: 50px;
        margin-bottom: 17px;
        color: #333;
      }
      h2 {
        font-size: 24px;
        line-height: 1.6;
        margin: 30px 0 0 0;
        margin-bottom: 18px;
        margin-top: 33px;
        color: #333;
      }
      h3 {
        font-size: 30px;
        margin: 10px 0 20px 0;
        color: #333;
      }
      header {
        width: 640px;
        margin: auto;
      }
      section {
        width: 640px;
        margin: auto;
      }
      section p {
        margin-bottom: 27px;
        font-size: 20px;
        line-height: 1.6;
        color: #333;
      }
      section img {
        max-width: 640px;
      }
      footer {
        padding: 0 20px;
        margin: 50px 0;
        text-align: center;
        font-size: 12px;
      }
      .aspectRatioPlaceholder {
        max-width: auto !important;
        max-height: auto !important;
      }
      .aspectRatioPlaceholder-fill {
        padding-bottom: 0 !important;
      }
      header,
      section[data-field=subtitle],
      section[data-field=description] {
        display: none;
      }
      </style></head><body><article class="h-entry">
<header>
<h1 class="p-name">Information Disclosure : APPRENTICE : Source code disclosure via backup files</h1>
</header>
<section data-field="subtitle" class="p-summary">
Web Security Academy &gt;&gt;Information disclosure &gt;&gt; Exploiting &gt;&gt; Lab
</section>
<section data-field="body" class="e-content">
<section name="5a1b" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="bc08" id="bc08" class="graf graf--h3 graf--leading graf--title">Information Disclosure : APPRENTICE : Source code disclosure via backup files</h3><p name="142e" id="142e" class="graf graf--p graf-after--h3"><a href="https://portswigger.net/web-security" data-href="https://portswigger.net/web-security" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Web Security Academy</a> &gt;&gt;<a href="https://portswigger.net/web-security/information-disclosure" data-href="https://portswigger.net/web-security/information-disclosure" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Information disclosure</a> &gt;&gt; <a href="https://portswigger.net/web-security/information-disclosure/exploiting" data-href="https://portswigger.net/web-security/information-disclosure/exploiting" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Exploiting</a> &gt;&gt; <a href="https://portswigger.net/web-security/information-disclosure/exploiting/lab-infoleak-via-backup-files" data-href="https://portswigger.net/web-security/information-disclosure/exploiting/lab-infoleak-via-backup-files" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Lab</a></p><figure name="bcc5" id="bcc5" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*vZyi4OoTh2TDEYKzyH2pbg.png" data-width="1201" data-height="494" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*vZyi4OoTh2TDEYKzyH2pbg.png"></figure><p name="e787" id="e787" class="graf graf--p graf-after--figure">This lab leaks its source code via backup files in a hidden directory. To solve the lab, identify and submit the database password, which is hard-coded in the leaked source code .</p><p name="b2aa" id="b2aa" class="graf graf--p graf-after--p">If the source code is in the backup files, and also two backup files are in a hidden directory, then we have to find that directory :</p><blockquote name="bd66" id="bd66" class="graf graf--blockquote graf-after--p">https://0af100de0405d8cc805bb22a004a0053.web-security-academy.net/<strong class="markup--strong markup--blockquote-strong">robots.txt</strong></blockquote><p name="439e" id="439e" class="graf graf--p graf-after--blockquote">The “robots .txt” directory is often used, because the robots.txt file is a useful tool for managing how a website interacts with search engines, but it must be kept in mind that using it is not an effective way to block access to sensitive resources. These instructions specify which pages should Or it should not be indexed by these engines.</p><figure name="8515" id="8515" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*wS4qo47vPD3xnSh5K2C03w.png" data-width="1124" data-height="140" src="https://cdn-images-1.medium.com/max/800/1*wS4qo47vPD3xnSh5K2C03w.png"></figure><p name="82d4" id="82d4" class="graf graf--p graf-after--figure">We’ve already found a backup file for that :</p><figure name="c81d" id="c81d" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*2fpMfh6TZ59QqQpt6zqTbg.png" data-width="1093" data-height="240" src="https://cdn-images-1.medium.com/max/800/1*2fpMfh6TZ59QqQpt6zqTbg.png"></figure><p name="29c7" id="29c7" class="graf graf--p graf-after--figure">And when we opened that file ProductTemplate.java.bak:</p><figure name="be77" id="be77" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*zUcay99tdgymGjjhujwf4Q.png" data-width="1309" data-height="855" src="https://cdn-images-1.medium.com/max/800/1*zUcay99tdgymGjjhujwf4Q.png"></figure><p name="f1a3" id="f1a3" class="graf graf--p graf-after--figure">We can also find the backup file in another way. You can continue reading if you want to benefit…….</p><p name="473a" id="473a" class="graf graf--p graf-after--p">In short, this means that you use <a href="https://github.com/epi052/feroxbuster" data-href="https://github.com/epi052/feroxbuster" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">FeroxBuster</a> to scan the specified location while using the specified list of<a href="https://github.com/Bo0oM/fuzz.txt/blob/master/fuzz.txt" data-href="https://github.com/Bo0oM/fuzz.txt/blob/master/fuzz.txt" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank"> words</a> to search for hidden or unknown files and paths.</p><figure name="26d8" id="26d8" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*g7VyLH5SVTinvXMQQjjFAw.png" data-width="1071" data-height="212" src="https://cdn-images-1.medium.com/max/800/1*g7VyLH5SVTinvXMQQjjFAw.png"></figure><p name="c3ad" id="c3ad" class="graf graf--p graf-after--figure">Indeed, in the end, we found what we wanted and reached the same file .</p><blockquote name="36d6" id="36d6" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">See you soon in other reports….!!</em></strong></blockquote><blockquote name="7158" id="7158" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">Abdelwahab_Shandy</em></strong></blockquote><blockquote name="f1b3" id="f1b3" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">AS_Cyber</em></strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/dfea5b8770e6"><time class="dt-published" datetime="2024-04-27T20:30:52.641Z">April 27, 2024</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/lab-source-code-disclosure-via-backup-files-dfea5b8770e6" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>