<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>Access control vulnerabilities : APPRENTICE : Unprotected admin functionality with unpredictable…</title><style>
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
<h1 class="p-name">Access control vulnerabilities : APPRENTICE : Unprotected admin functionality with unpredictable…</h1>
</header>
<section data-field="subtitle" class="p-summary">
Web Security Academy &gt;&gt; Access control &gt;&gt; Lab
</section>
<section data-field="body" class="e-content">
<section name="f1fb" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="66a3" id="66a3" class="graf graf--h3 graf--leading graf--title">Access control vulnerabilities : APPRENTICE : Unprotected admin functionality with unpredictable URL</h3><p name="c3fe" id="c3fe" class="graf graf--p graf-after--h3"><a href="https://portswigger.net/web-security" data-href="https://portswigger.net/web-security" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Web Security Academy</a> <a href="https://portswigger.net/web-security/access-control" data-href="https://portswigger.net/web-security/access-control" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">&gt;&gt; Access control</a> &gt;&gt; <a href="https://portswigger.net/web-security/access-control/lab-unprotected-admin-functionality-with-unpredictable-url" data-href="https://portswigger.net/web-security/access-control/lab-unprotected-admin-functionality-with-unpredictable-url" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Lab</a></p><figure name="ffc3" id="ffc3" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*xGWJg_OND_SRKMecmnJSPw.png" data-width="1194" data-height="469" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*xGWJg_OND_SRKMecmnJSPw.png"></figure><p name="b6e4" id="b6e4" class="graf graf--p graf-after--figure">So we have to access the admin panel first ??</p><p name="d194" id="d194" class="graf graf--p graf-after--p">After I searched and collected information on the site and also tried to find out if there was a hidden directory, but I did not find anything either, so we will read the site code :</p><figure name="e28c" id="e28c" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*_kz9mbEmbYyik93SJYq8tA.png" data-width="1152" data-height="359" src="https://cdn-images-1.medium.com/max/800/1*_kz9mbEmbYyik93SJYq8tA.png"><figcaption class="imageCaption">I found this piece in the code like this:</figcaption></figure><p name="23f1" id="23f1" class="graf graf--p graf-after--figure">This code checks a variable called “isAdmin”, which determines whether the user is an administrator (administrator) of the site or not. If the value of the variable is “false”, the “if” condition will not be met and the code within it will not be executed.</p><p name="e06e" id="e06e" class="graf graf--p graf-after--p">If “isAdmin” is “true”, the “if” condition is entered, where the HTML element is targeted using the “top-links” class, which is typically thought of as the list of top links on a web page. Next, create a new element “a” that will be a link to the Admin panel, and assign it the title “Admin panel” and the link “/admin-w4szmz”. After that, this link is added to the list of top links.</p><p name="7be7" id="7be7" class="graf graf--p graf-after--p">Then, a new ‘p’ element is created containing the text ‘|’, which is also added to the top link list.</p><p name="a6ab" id="a6ab" class="graf graf--p graf-after--p">It is clear that the goal of this code is to display a link to the control panel for the administrator according to the value of the variable “isAdmin”, as this link appears only if the user is the site administrator.</p><p name="009b" id="009b" class="graf graf--p graf-after--p">So we can use /admin-w4szmz with the main URL to redirect us to the admin panel.</p><figure name="d099" id="d099" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*NwPwbL3zS6Q4k0FDs0MPhw.png" data-width="1309" data-height="527" src="https://cdn-images-1.medium.com/max/800/1*NwPwbL3zS6Q4k0FDs0MPhw.png"><figcaption class="imageCaption">Congratulations, you solved the lab!</figcaption></figure><p name="87e1" id="87e1" class="graf graf--p graf-after--figure">Well, delete the user Carlos and then you win .</p><blockquote name="e0ec" id="e0ec" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong">See you soon in other reports….!!</strong></blockquote><blockquote name="03fa" id="03fa" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">Abdelwahab_Shandy</strong></blockquote><blockquote name="3028" id="3028" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong">AS_Cyber</strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/83f83eee86a4"><time class="dt-published" datetime="2024-04-29T21:38:48.791Z">April 29, 2024</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/access-control-vulnerabilities-apprentice-unprotected-admin-functionality-with-unpredictable-83f83eee86a4" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>