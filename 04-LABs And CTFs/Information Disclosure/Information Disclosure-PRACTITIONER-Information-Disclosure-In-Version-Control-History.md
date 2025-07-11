<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>Lab : PRACTITIONER : Information disclosure in version control history</title><style>
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
<h1 class="p-name">Lab : PRACTITIONER : Information disclosure in version control history</h1>
</header>
<section data-field="subtitle" class="p-summary">
Web Security Academy &gt;&gt; Information disclosure &gt;&gt; Exploiting &gt;&gt; Lab
</section>
<section data-field="body" class="e-content">
<section name="0299" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="066b" id="066b" class="graf graf--h3 graf--leading graf--title">Information Disclosure : PRACTITIONER : <a href="https://portswigger.net/web-security/information-disclosure" data-href="https://portswigger.net/web-security/information-disclosure" class="markup--anchor markup--h3-anchor" rel="noopener" target="_blank">Information disclosure</a> in version control history</h3><p name="c4c3" id="c4c3" class="graf graf--p graf-after--h3"><a href="https://portswigger.net/web-security" data-href="https://portswigger.net/web-security" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Web Security Academy</a> &gt;&gt; <a href="https://portswigger.net/web-security/information-disclosure" data-href="https://portswigger.net/web-security/information-disclosure" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Information disclosure</a> &gt;&gt; <a href="https://portswigger.net/web-security/information-disclosure/exploiting" data-href="https://portswigger.net/web-security/information-disclosure/exploiting" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Exploiting</a> &gt;&gt; <a href="https://portswigger.net/web-security/information-disclosure/exploiting/lab-infoleak-in-version-control-history" data-href="https://portswigger.net/web-security/information-disclosure/exploiting/lab-infoleak-in-version-control-history" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Lab</a></p><p name="6540" id="6540" class="graf graf--p graf-after--p">This lab discloses sensitive information via its version control history. To solve the lab, obtain the password for the <code class="markup--code markup--p-code">administrator</code> user then log in and delete the user <code class="markup--code markup--p-code">carlos</code>.</p><figure name="758d" id="758d" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*rQSi-v3w0op-QAr8BN4h0A.png" data-width="1203" data-height="489" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*rQSi-v3w0op-QAr8BN4h0A.png"></figure><p name="a853" id="a853" class="graf graf--p graf-after--figure">The task here is to find the admin’s password and then delete the user Carlos ……………</p><p name="0889" id="0889" class="graf graf--p graf-after--p">In short, this command runs the <a href="https://github.com/epi052/feroxbuster" data-href="https://github.com/epi052/feroxbuster" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank"><strong class="markup--strong markup--p-strong">FeroxBuster</strong> </a>tool to discover paths and files on the specified location using the specified list of <a href="https://github.com/Bo0oM/fuzz.txt/blob/master/fuzz.txt" data-href="https://github.com/Bo0oM/fuzz.txt/blob/master/fuzz.txt" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank"><strong class="markup--strong markup--p-strong">words</strong></a>.</p><figure name="3a1f" id="3a1f" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*9lzfuGonVlM2LCXBmQQvlA.png" data-width="842" data-height="141" src="https://cdn-images-1.medium.com/max/800/1*9lzfuGonVlM2LCXBmQQvlA.png"></figure><p name="f192" id="f192" class="graf graf--p graf-after--figure">Indeed, he has brought out some important paths for me here :</p><figure name="5a23" id="5a23" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*_c-RVKyivTfWbyNTKeEIfw.png" data-width="1330" data-height="332" src="https://cdn-images-1.medium.com/max/800/1*_c-RVKyivTfWbyNTKeEIfw.png"></figure><p name="5bd8" id="5bd8" class="graf graf--p graf-after--figure">When you open this guide, you will find the following :</p><figure name="d665" id="d665" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*RfrJVNGgs3TyxQGx7xSPdA.png" data-width="1065" data-height="589" src="https://cdn-images-1.medium.com/max/800/1*RfrJVNGgs3TyxQGx7xSPdA.png"></figure><p name="ba05" id="ba05" class="graf graf--p graf-after--figure">When I searched here I found the following :</p><figure name="f02f" id="f02f" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*kdFl2CpczO8kCVBbHjXafA.png" data-width="1950" data-height="135" src="https://cdn-images-1.medium.com/max/800/1*kdFl2CpczO8kCVBbHjXafA.png"></figure><p name="4539" id="4539" class="graf graf--p graf-after--figure">These two sentences refer to a series of actions in the software development process, usually done using a version control system such as Git. Let me explain to you:</p><p name="1749" id="1749" class="graf graf--p graf--startsWithDoubleQuote graf-after--p">“commit (initial): Add skeleton admin panel”:<br> “commit”: A Git term that refers to logging specific changes to files in a Git repository.<br> “(initial)”: Indicates that this comment relates to the first or basic modifications to the project.<br> “Add skeleton admin panel”: A description of the changes made, whereby a skeleton (or template) of the Admin Panel interface (Admin Panel) has been added to the project.</p><p name="c362" id="c362" class="graf graf--p graf--startsWithDoubleQuote graf-after--p">“Remove admin password from config”:<br> This comment indicates another change made to the project.<br> It appears that the Admin password has been removed from the config file, possibly for security reasons or to avoid putting a sensitive password in a public file.<br>But do not forget, our mission is to find the password for the admin , so :</p><figure name="0a3a" id="0a3a" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*8Wi79XncBAQ4OCGhgFmecA.png" data-width="694" data-height="91" src="https://cdn-images-1.medium.com/max/800/1*8Wi79XncBAQ4OCGhgFmecA.png"></figure><p name="91d7" id="91d7" class="graf graf--p graf-after--figure">This command uses the wget tool to download (or retrieve) the content of the .git folder from the specified website. Let’s explain it:</p><p name="da2b" id="da2b" class="graf graf--p graf-after--p">wget: is a Linux command used to download files from the web.</p><p name="fa25" id="fa25" class="graf graf--p graf-after--p">-r: This option means “read resources recursively”, and indicates that wget should recursively download all links on the target page.</p><p name="d1b1" id="d1b1" class="graf graf--p graf-after--p"><a href="https://0a5b00af03d5a8af805d3fcf00a600ea.web-security-academy.net/.git/" data-href="https://0a5b00af03d5a8af805d3fcf00a600ea.web-security-academy.net/.git/" class="markup--anchor markup--p-anchor" rel="nofollow noopener" target="_blank">https://0a5b00af03d5a8af805d3fcf00a600ea.web-security-academy.net/.git/</a>: This is the URL of the .git folder in the target website, it contains the .git folder, which is the Git version control system folder that contains all the history of changes and related data With the project.</p><p name="6c8d" id="6c8d" class="graf graf--p graf-after--p">In short, this command uses wget to download the content of the .git folder from the specified website, enabling the user to access all version data and changes in the project, which is exactly what we want, so we don’t see</p><figure name="a050" id="a050" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*9kQNc04AzZpcWcqhfN7Fgw.png" data-width="709" data-height="445" src="https://cdn-images-1.medium.com/max/800/1*9kQNc04AzZpcWcqhfN7Fgw.png"></figure><p name="fe14" id="fe14" class="graf graf--p graf-after--figure">Now we will open the downloaded file :</p><figure name="2e87" id="2e87" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*AM0OZYi6EAdeYU0hLmVzbg.png" data-width="832" data-height="649" src="https://cdn-images-1.medium.com/max/800/1*AM0OZYi6EAdeYU0hLmVzbg.png"></figure><p name="b27c" id="b27c" class="graf graf--p graf-after--figure">We will restore the commit :</p><figure name="0da8" id="0da8" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*SEdEsAyNIeeQNpW7L7eVZw.png" data-width="830" data-height="476" src="https://cdn-images-1.medium.com/max/800/1*SEdEsAyNIeeQNpW7L7eVZw.png"></figure><p name="774f" id="774f" class="graf graf--p graf-after--figure">Of course yes :</p><figure name="4341" id="4341" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*ms66DacKsl0a5ZGriVz8kw.png" data-width="731" data-height="279" src="https://cdn-images-1.medium.com/max/800/1*ms66DacKsl0a5ZGriVz8kw.png"></figure><p name="5efd" id="5efd" class="graf graf--p graf-after--figure">It will show what the admin has already done :</p><figure name="cfbd" id="cfbd" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*UyiPqtfUlYW0jYVK10vx0g.png" data-width="536" data-height="391" src="https://cdn-images-1.medium.com/max/800/1*UyiPqtfUlYW0jYVK10vx0g.png"></figure><p name="f56b" id="f56b" class="graf graf--p graf-after--figure">Now that we have obtained the password, we will enter the admin panel :</p><figure name="2f96" id="2f96" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*WnrKIk6f_Tpc8FApc6yDhg.png" data-width="1001" data-height="478" src="https://cdn-images-1.medium.com/max/800/1*WnrKIk6f_Tpc8FApc6yDhg.png"></figure><p name="b2fc" id="b2fc" class="graf graf--p graf-after--figure">Already logged in :</p><figure name="8eed" id="8eed" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*V2iYQ1RpsrYyuQEGG59Paw.png" data-width="1623" data-height="526" src="https://cdn-images-1.medium.com/max/800/1*V2iYQ1RpsrYyuQEGG59Paw.png"></figure><p name="0671" id="0671" class="graf graf--p graf-after--figure">We will delete the carlos user</p><figure name="8e3e" id="8e3e" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*_BEJPU8SQJfWJLxqnm4Vsg.png" data-width="1620" data-height="271" src="https://cdn-images-1.medium.com/max/800/1*_BEJPU8SQJfWJLxqnm4Vsg.png"></figure><p name="8cc2" id="8cc2" class="graf graf--p graf-after--figure">Yes, we succeeded this time too</p><figure name="f702" id="f702" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*Zruo4pREvFJ70DGGj51tFg.png" data-width="1642" data-height="599" src="https://cdn-images-1.medium.com/max/800/1*Zruo4pREvFJ70DGGj51tFg.png"><figcaption class="imageCaption">Congratulations, you solved the lab!</figcaption></figure><blockquote name="29cb" id="29cb" class="graf graf--blockquote graf-after--figure"><strong class="markup--strong markup--blockquote-strong">See you soon in other reports….!!</strong></blockquote><blockquote name="ffbd" id="ffbd" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">Abdelwahab_Shandy</strong></blockquote><blockquote name="07ea" id="07ea" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong">AS_Cyber</strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/93d25f050ee6"><time class="dt-published" datetime="2024-04-27T22:08:08.062Z">April 27, 2024</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/lab-practitioner-information-disclosure-in-version-control-history-93d25f050ee6" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>