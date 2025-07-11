<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>Access control vulnerabilities : APPRENTICE : User ID controlled by request parameter</title><style>
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
<h1 class="p-name">Access control vulnerabilities : APPRENTICE : User ID controlled by request parameter</h1>
</header>
<section data-field="subtitle" class="p-summary">
Web Security Academy &gt;&gt; Access control &gt;&gt; Lab
</section>
<section data-field="body" class="e-content">
<section name="b57d" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="a63d" id="a63d" class="graf graf--h3 graf--leading graf--title">Access control vulnerabilities : APPRENTICE : User ID controlled by request parameter</h3><p name="5d34" id="5d34" class="graf graf--p graf-after--h3"><a href="https://portswigger.net/web-security" data-href="https://portswigger.net/web-security" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Web Security Academy</a> &gt;&gt; <a href="https://portswigger.net/web-security/access-control" data-href="https://portswigger.net/web-security/access-control" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Access control</a> &gt;&gt; <a href="https://portswigger.net/web-security/access-control/lab-user-id-controlled-by-request-parameter" data-href="https://portswigger.net/web-security/access-control/lab-user-id-controlled-by-request-parameter" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Lab</a></p><figure name="42a0" id="42a0" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*dfUpcimX2SYwBfEV-srOYQ.png" data-width="1229" data-height="486" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*dfUpcimX2SYwBfEV-srOYQ.png"></figure><p name="14b0" id="14b0" class="graf graf--p graf-after--figure">The goal is to get the API key of user carlos :</p><p name="f7fc" id="f7fc" class="graf graf--p graf-after--p">We will log in with wiener:peter .</p><figure name="9246" id="9246" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*2qtFFwuicoqQiWKT359ybQ.png" data-width="1605" data-height="824" src="https://cdn-images-1.medium.com/max/800/1*2qtFFwuicoqQiWKT359ybQ.png"></figure><p name="6d27" id="6d27" class="graf graf--p graf-after--figure">So to get the API Key, we must go to Carlos’s page .</p><figure name="7999" id="7999" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*MN1GZUQY9nwdjNf0ONOpbw.png" data-width="898" data-height="67" src="https://cdn-images-1.medium.com/max/800/1*MN1GZUQY9nwdjNf0ONOpbw.png"></figure><p name="2543" id="2543" class="graf graf--p graf-after--figure">If you notice in the URL, the user ID appears as the user name, so we can change the name to the user Carlos .</p><figure name="5aeb" id="5aeb" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*tl8UVYwYmYako6VQUInl-A.png" data-width="1032" data-height="649" src="https://cdn-images-1.medium.com/max/800/1*tl8UVYwYmYako6VQUInl-A.png"></figure><p name="b2ca" id="b2ca" class="graf graf--p graf-after--figure">We need to change the id from wiener to carlos</p><figure name="8f07" id="8f07" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*NQbqKVxKL1Zhm4mvaiksKw.png" data-width="552" data-height="252" src="https://cdn-images-1.medium.com/max/800/1*NQbqKVxKL1Zhm4mvaiksKw.png"></figure><p name="f1a3" id="f1a3" class="graf graf--p graf-after--figure">Therefore, we will send the request to the repeater :</p><figure name="7c30" id="7c30" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*rDyZwX03R0P9mmUvRuz1pQ.png" data-width="1321" data-height="239" src="https://cdn-images-1.medium.com/max/800/1*rDyZwX03R0P9mmUvRuz1pQ.png"></figure><p name="6402" id="6402" class="graf graf--p graf-after--figure">Change the ID , And send the request :</p><figure name="090c" id="090c" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*Y8Ua6pnC9L-Q5PssC8Yavw.png" data-width="1326" data-height="499" src="https://cdn-images-1.medium.com/max/800/1*Y8Ua6pnC9L-Q5PssC8Yavw.png"></figure><p name="7b2c" id="7b2c" class="graf graf--p graf-after--figure">The response came and he has already registered using the user carlos, so search in the search box for “API”.</p><figure name="21e9" id="21e9" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*_v0-tE1EqGbLJW06BzThVA.png" data-width="529" data-height="276" src="https://cdn-images-1.medium.com/max/800/1*_v0-tE1EqGbLJW06BzThVA.png"></figure><p name="4105" id="4105" class="graf graf--p graf-after--figure">Here we are .</p><figure name="f841" id="f841" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*HaM0JUyibTl4niS90KdWyQ.png" data-width="839" data-height="594" src="https://cdn-images-1.medium.com/max/800/1*HaM0JUyibTl4niS90KdWyQ.png"><figcaption class="imageCaption">Congratulations, you solved the lab!</figcaption></figure><p name="4df4" id="4df4" class="graf graf--p graf-after--figure">We could have changed the ID from wiener to carlos inside the URL and see what happens , Sometimes it works, but on this site it did not work, so we logged in to the user Carlos, using burp .</p><blockquote name="6d2b" id="6d2b" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong">See you soon in other reports….!!</strong></blockquote><blockquote name="48d9" id="48d9" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">Abdelwahab_Shandy</strong></blockquote><blockquote name="2775" id="2775" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong">AS_Cyber</strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/07d692e4785a"><time class="dt-published" datetime="2024-05-02T22:34:19.515Z">May 2, 2024</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/access-control-vulnerabilities-apprentice-user-id-controlled-by-request-parameter-07d692e4785a" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>