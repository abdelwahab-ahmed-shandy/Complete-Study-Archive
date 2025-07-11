<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>Lab: APPRENTICE :  Authentication bypass via information disclosure</title><style>
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
<h1 class="p-name">Lab: APPRENTICE :  Authentication bypass via information disclosure</h1>
</header>
<section data-field="subtitle" class="p-summary">
Web Security Academy &gt;&gt; Information disclosure &gt;&gt; Exploiting &gt;&gt; Lab
</section>
<section data-field="body" class="e-content">
<section name="6050" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="b453" id="b453" class="graf graf--h3 graf--leading graf--title">Information Disclosure : APPRENTICE : Authentication bypass via <a href="https://portswigger.net/web-security/information-disclosure" data-href="https://portswigger.net/web-security/information-disclosure" class="markup--anchor markup--h3-anchor" rel="noopener" target="_blank">information disclosure</a></h3><p name="d3b2" id="d3b2" class="graf graf--p graf-after--h3"><a href="https://portswigger.net/web-security" data-href="https://portswigger.net/web-security" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Web Security Academy</a> &gt;&gt; <a href="https://portswigger.net/web-security/information-disclosure" data-href="https://portswigger.net/web-security/information-disclosure" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Information disclosure</a> &gt;&gt; <a href="https://portswigger.net/web-security/information-disclosure/exploiting" data-href="https://portswigger.net/web-security/information-disclosure/exploiting" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Exploiting</a> &gt;&gt; <a href="https://portswigger.net/web-security/information-disclosure/exploiting/lab-infoleak-authentication-bypass" data-href="https://portswigger.net/web-security/information-disclosure/exploiting/lab-infoleak-authentication-bypass" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Lab</a></p><figure name="9f50" id="9f50" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*jdVEHXh4QWe6SvRuGRviZg.png" data-width="1200" data-height="538" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*jdVEHXh4QWe6SvRuGRviZg.png"></figure><p name="3921" id="3921" class="graf graf--p graf-after--figure">Learn to log in using the username and password : <code class="markup--code markup--p-code">wiener:peter</code></p><figure name="c66f" id="c66f" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*xQFwvIHKKIOMC9Bhj8Jssg.png" data-width="882" data-height="71" src="https://cdn-images-1.medium.com/max/800/1*xQFwvIHKKIOMC9Bhj8Jssg.png"></figure><p name="61bc" id="61bc" class="graf graf--p graf-after--figure">browse to GET /admin :</p><figure name="48fd" id="48fd" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*kTDT5fIhzY0bnncRgD_u2A.png" data-width="1200" data-height="399" src="https://cdn-images-1.medium.com/max/800/1*kTDT5fIhzY0bnncRgD_u2A.png"></figure><p name="daea" id="daea" class="graf graf--p graf-after--figure">If we go to the Burp :</p><figure name="8723" id="8723" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*Yf-0d0uM_cT6mnfcnleVaA.png" data-width="1584" data-height="962" src="https://cdn-images-1.medium.com/max/800/1*Yf-0d0uM_cT6mnfcnleVaA.png"></figure><p name="5c8a" id="5c8a" class="graf graf--p graf-after--figure">We can change the GET in the TRACE , By sending it to Repeater :</p><figure name="0780" id="0780" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*upi4taXClZfylf2X4jom4Q.png" data-width="791" data-height="219" src="https://cdn-images-1.medium.com/max/800/1*upi4taXClZfylf2X4jom4Q.png"></figure><p name="e06e" id="e06e" class="graf graf--p graf-after--figure">Then :</p><figure name="f442" id="f442" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*4-adsmP4rJflqlD02KTPxQ.png" data-width="1052" data-height="605" src="https://cdn-images-1.medium.com/max/800/1*4-adsmP4rJflqlD02KTPxQ.png"></figure><p name="9b4a" id="9b4a" class="graf graf--p graf-after--figure">This X-Custom-IP-Authorization header has the IP address “156.174.229.54”. IP addresses are commonly used to identify communication sources in networks. In this case, the header could be part of a custom authentication system where IP addresses are used to determine access to resources or services.</p><p name="8251" id="8251" class="graf graf--p graf-after--p"><code class="markup--code markup--p-code">X-Custom-IP-Authorization: 127.0.0.1</code></p><p name="d803" id="d803" class="graf graf--p graf-after--p">If we change “X-Custom-IP-Authorization: 156.174.229.54” to “X-Custom-IP-Authorization: 127.0.0.1”……………….<br>This X-Custom-IP-Authorization header has the IP address “127.0.0.1”. The address 127.0.0.1 refers to the address of “localhost” or your computer itself. Mostly, this type of header is used to validate requests or to manage access. This header can have different meanings depending on the context in which it is used, for example if it is part of a custom authentication scheme, if we use it with GET in the TRACE and set X-Custom-IP-Authorization: 127.0.0.1 with the request .</p><p name="3f7e" id="3f7e" class="graf graf--p graf-after--p">So I’m going to run intercept , Let us change the order as follows<br>We will add “X-Custom-IP-Authorization: 127.0.0.1” to each request :</p><figure name="7894" id="7894" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*fVRwW47YR-b5xojOr89PbQ.png" data-width="638" data-height="448" src="https://cdn-images-1.medium.com/max/800/1*fVRwW47YR-b5xojOr89PbQ.png"></figure><p name="b1ba" id="b1ba" class="graf graf--p graf-after--figure">in this way , Then we will delete the user carlos :</p><figure name="ed7c" id="ed7c" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*zbvxNUuc1TtfwVfGnZHwZQ.png" data-width="1191" data-height="465" src="https://cdn-images-1.medium.com/max/800/1*zbvxNUuc1TtfwVfGnZHwZQ.png"></figure><p name="63d4" id="63d4" class="graf graf--p graf-after--figure">Don’t forget to put “X-Custom-IP-Authorization: 127.0.0.1” in each request :</p><figure name="5ff9" id="5ff9" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*67Oisi3BV6mmwZmRB-0csg.png" data-width="1053" data-height="580" src="https://cdn-images-1.medium.com/max/800/1*67Oisi3BV6mmwZmRB-0csg.png"><figcaption class="imageCaption">Congratulations, you solved the lab!</figcaption></figure><blockquote name="6ef6" id="6ef6" class="graf graf--blockquote graf-after--figure"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">See you soon in other reports….!!</em></strong></blockquote><blockquote name="4871" id="4871" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">Abdelwahab_Shandy</em></strong></blockquote><blockquote name="34c0" id="34c0" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">AS_Cyber</em></strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/ab11f25aa53b"><time class="dt-published" datetime="2024-04-28T20:38:31.831Z">April 28, 2024</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/lab-apprentice-authentication-bypass-via-information-disclosure-ab11f25aa53b" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>