<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>Access control vulnerabilities : APPRENTICE : Unprotected admin functionality</title><style>
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
<h1 class="p-name">Access control vulnerabilities : APPRENTICE : Unprotected admin functionality</h1>
</header>
<section data-field="subtitle" class="p-summary">
Web Security Academy &gt;&gt; Access control &gt;&gt; Lab
</section>
<section data-field="body" class="e-content">
<section name="1347" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="8758" id="8758" class="graf graf--h3 graf--leading graf--title">Access control vulnerabilities : APPRENTICE : Unprotected admin functionality</h3><p name="a3b0" id="a3b0" class="graf graf--p graf-after--h3"><a href="https://portswigger.net/web-security" data-href="https://portswigger.net/web-security" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Web Security Academy</a> &gt;&gt; <a href="https://portswigger.net/web-security/access-control" data-href="https://portswigger.net/web-security/access-control" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Access control</a> &gt;&gt; <a href="https://portswigger.net/web-security/access-control/lab-unprotected-admin-functionality" data-href="https://portswigger.net/web-security/access-control/lab-unprotected-admin-functionality" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Lab</a></p><figure name="e066" id="e066" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*ikzP8lspInONcpPcWKJnIQ.png" data-width="1191" data-height="429" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*ikzP8lspInONcpPcWKJnIQ.png"></figure><p name="165b" id="165b" class="graf graf--p graf-after--figure">So first we have to access the admin panel ؟؟</p><p name="87a0" id="87a0" class="graf graf--p graf-after--p">After collecting information on the site, I see no better guess than discovering hidden directories and files on web servers, because I don’t have any login data so we will do the following:</p><figure name="88e3" id="88e3" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*zP6a_H08WRBq_DYZB5r9_A.png" data-width="862" data-height="73" src="https://cdn-images-1.medium.com/max/800/1*zP6a_H08WRBq_DYZB5r9_A.png"></figure><p name="3695" id="3695" class="graf graf--p graf-after--figure">In this context, the command appears to be used to scan a specific URL, which is “<a href="https://0a13006e035c43fd8596df8700f9007f.web-security-academy.net/" data-href="https://0a13006e035c43fd8596df8700f9007f.web-security-academy.net/" class="markup--anchor markup--p-anchor" rel="nofollow noopener" target="_blank">https://0a13006e035c43fd8596df8700f9007f.web-security-academy.net/</a>&quot;, using a specific wordlist called “fuzz.txt”, which contains a set Potential keywords that could be used in an attack on the application.</p><p name="07d8" id="07d8" class="graf graf--p graf-after--p">In more detail:</p><p name="f6b2" id="f6b2" class="graf graf--p graf--startsWithDoubleQuote graf-after--p">“-u” specifies the URL to be scanned.<br> “-w” specifies the path to the wordlist to be used in the attack.</p><figure name="4789" id="4789" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*j5v75wvMNebqEyl8W1WUOg.png" data-width="1323" data-height="220" src="https://cdn-images-1.medium.com/max/800/1*j5v75wvMNebqEyl8W1WUOg.png"></figure><p name="3782" id="3782" class="graf graf--p graf-after--figure"><strong class="markup--strong markup--p-strong">Robots.txt</strong> file is a file used by site owners to instruct search engines about which pages they are allowed to visit and which should be ignored.</p><p name="4cfd" id="4cfd" class="graf graf--p graf-after--p">When you visit this link, you will likely see restrictive search engine instructions, specifying which pages should not be indexed, and which pages should be indexed.</p><p name="9fad" id="9fad" class="graf graf--p graf-after--p">For example, Robots.txt files can contain instructions such as:</p><p name="3722" id="3722" class="graf graf--p graf-after--p">Determine which folders should not be indexed.<br> Identify specific files that search engines should not visit.<br> Determine the search engine definition sites (sitemap) for the site.</p><p name="9e30" id="9e30" class="graf graf--p graf-after--p">Scanning the Robots.txt file can be an important part of the security scan process and evaluating potential attacks on the site.</p><figure name="c138" id="c138" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*H1to3om8VmRieQWtt57_Zw.png" data-width="1376" data-height="143" src="https://cdn-images-1.medium.com/max/800/1*H1to3om8VmRieQWtt57_Zw.png"></figure><p name="8d21" id="8d21" class="graf graf--p graf-after--figure">We will add this page with the link /administrator-panel , Let’s see what happens :</p><figure name="73ac" id="73ac" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*UDE4iqouwAtqRb2hk93UtA.png" data-width="1231" data-height="526" src="https://cdn-images-1.medium.com/max/800/1*UDE4iqouwAtqRb2hk93UtA.png"></figure><p name="b04d" id="b04d" class="graf graf--p graf-after--figure">Here we have reached the admin panel , Now we will delete the user carlos :</p><figure name="0cbe" id="0cbe" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*R7gdZ612yJ4JayoMvXTN4g.png" data-width="639" data-height="394" src="https://cdn-images-1.medium.com/max/800/1*R7gdZ612yJ4JayoMvXTN4g.png"><figcaption class="imageCaption">Congratulations, you solved the lab!</figcaption></figure><blockquote name="687e" id="687e" class="graf graf--blockquote graf-after--figure"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">See you soon in other reports….!!</em></strong></blockquote><blockquote name="21d5" id="21d5" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">Abdelwahab_Shandy</em></strong></blockquote><blockquote name="badc" id="badc" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">AS_Cyber</em></strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/776bc66a5b5a"><time class="dt-published" datetime="2024-04-29T21:08:53.905Z">April 29, 2024</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/access-control-vulnerabilities-apprentice-unprotected-admin-functionality-776bc66a5b5a" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>