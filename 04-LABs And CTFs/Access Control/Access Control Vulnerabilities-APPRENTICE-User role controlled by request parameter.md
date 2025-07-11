<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>Access control vulnerabilities : APPRENTICE : User role controlled by request parameter</title><style>
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
<h1 class="p-name">Access control vulnerabilities : APPRENTICE : User role controlled by request parameter</h1>
</header>
<section data-field="subtitle" class="p-summary">
Web Security Academy &gt;&gt; Access control &gt;&gt; Lab
</section>
<section data-field="body" class="e-content">
<section name="bff9" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="de68" id="de68" class="graf graf--h3 graf--leading graf--title">Access control vulnerabilities : APPRENTICE : User role controlled by request parameter</h3><p name="fc1c" id="fc1c" class="graf graf--p graf-after--h3"><a href="https://portswigger.net/web-security" data-href="https://portswigger.net/web-security" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Web Security Academy</a> &gt;&gt; <a href="https://portswigger.net/web-security/access-control" data-href="https://portswigger.net/web-security/access-control" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Access control</a> &gt;&gt; <a href="https://portswigger.net/web-security/access-control/lab-user-role-controlled-by-request-parameter" data-href="https://portswigger.net/web-security/access-control/lab-user-role-controlled-by-request-parameter" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Lab</a></p><figure name="1241" id="1241" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*SO3XBCneHFiSbBYzxfCKrw.png" data-width="1198" data-height="482" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*SO3XBCneHFiSbBYzxfCKrw.png"></figure><p name="dd5d" id="dd5d" class="graf graf--p graf-after--figure">Well, I checked the robots.txt file, and also the code for the site, and also guessed the hidden directory, but in the end I did not find anything, so we will use burp , But in the end we must access the admin panel ؟؟</p><p name="f2cc" id="f2cc" class="graf graf--p graf-after--p">So we tried adding /admin. We might achieve something, but:</p><figure name="7780" id="7780" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*Yuk7UN-nwiTMYAjNFLdGKA.png" data-width="1111" data-height="208" src="https://cdn-images-1.medium.com/max/800/1*Yuk7UN-nwiTMYAjNFLdGKA.png"></figure><p name="dd7c" id="dd7c" class="graf graf--p graf-after--figure">First of all, you must log in using “ wiener:peter ”.</p><p name="a005" id="a005" class="graf graf--p graf-after--p">But I found the message “Admin interface is only available if you are logged in as administrator”</p><figure name="810f" id="810f" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*EUPzK7tYv5gNLeJjQiMzYA.png" data-width="1045" data-height="400" src="https://cdn-images-1.medium.com/max/800/1*EUPzK7tYv5gNLeJjQiMzYA.png"></figure><p name="43f7" id="43f7" class="graf graf--p graf-after--figure">I will run intercept in burp , I will try again, adding admin again and narrating the request and it is going to the server :</p><figure name="90f4" id="90f4" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*_gcPlVzVB1VxK3_CVfNdVg.png" data-width="1329" data-height="379" src="https://cdn-images-1.medium.com/max/800/1*_gcPlVzVB1VxK3_CVfNdVg.png"></figure><p name="ce96" id="ce96" class="graf graf--p graf-after--figure">This series contains two cookies:</p><p name="7d9b" id="7d9b" class="graf graf--p graf--startsWithDoubleQuote graf-after--p">“Admin=false”: This cookie indicates that the current user is not a system administrator. A value of “false” indicates that he is not a manager.<br> “session=0dl420TfDQJuY2vIiMv6ZCC8W0z2wPAs”: This cookie is used to set the user’s session. This cookie is supposed to contain a session identifier that is used to identify the user and allow them to access appropriate content in the application.</p><p name="6445" id="6445" class="graf graf--p graf-after--p">So, if we change the value of “false” to “true”, will it then make me go to the admin panel? Let’s try.</p><pre data-code-block-mode="1" spellcheck="false" data-code-block-lang="vbnet" name="5f61" id="5f61" class="graf graf--pre graf-after--p graf--preV2"><span class="pre--content"><span class="hljs-symbol">Cookie:</span> Admin=<span class="hljs-literal">false</span>; session=<span class="hljs-number">0</span>dl420TfDQJuY2vIiMv6ZCC8W0z2wPAs</span></pre><figure name="86dc" id="86dc" class="graf graf--figure graf-after--pre"><img class="graf-image" data-image-id="1*VJ3xEjjguHCpaNEcht9P3g.png" data-width="1326" data-height="505" src="https://cdn-images-1.medium.com/max/800/1*VJ3xEjjguHCpaNEcht9P3g.png"></figure><p name="dac9" id="dac9" class="graf graf--p graf-after--figure">We have already changed the value and it has already entered the admin panel :</p><pre data-code-block-mode="1" spellcheck="false" data-code-block-lang="vbnet" name="185d" id="185d" class="graf graf--pre graf-after--p graf--preV2"><span class="pre--content"><span class="hljs-symbol">Cookie:</span> Admin=<span class="hljs-literal">true</span>; session=<span class="hljs-number">0</span>dl420TfDQJuY2vIiMv6ZCC8W0z2wPAs</span></pre><p name="c40e" id="c40e" class="graf graf--p graf-after--pre">Well, we have already reached the admin panel :</p><figure name="6d95" id="6d95" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*i2CqBXJOCbiQuPS6qJFPWg.png" data-width="1500" data-height="544" src="https://cdn-images-1.medium.com/max/800/1*i2CqBXJOCbiQuPS6qJFPWg.png"></figure><p name="bb13" id="bb13" class="graf graf--p graf-after--figure">But I ran into a problem when I deleted the user Carlos. He refused to do so. It seems that he checks the cookies on every request the user makes for that , We will do the following :</p><figure name="476e" id="476e" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*a6h0LVccHeVIs_hVYIdRfQ.png" data-width="694" data-height="145" src="https://cdn-images-1.medium.com/max/800/1*a6h0LVccHeVIs_hVYIdRfQ.png"><figcaption class="imageCaption">You will open the proxy settings .</figcaption></figure><p name="e66b" id="e66b" class="graf graf--p graf-after--figure">After that, go to match and replace rules , You will add a new part as follows :</p><figure name="6b7e" id="6b7e" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*65wr4eoAuOtIuSsc70SsFw.png" data-width="1348" data-height="538" src="https://cdn-images-1.medium.com/max/800/1*65wr4eoAuOtIuSsc70SsFw.png"></figure><p name="2fda" id="2fda" class="graf graf--p graf-after--figure">After this point and adding it from the burp, the curator will enable you to delete the user without stopping the request and modifying it:</p><blockquote name="7e83" id="7e83" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong">See you soon in other reports….!!</strong></blockquote><blockquote name="2bc0" id="2bc0" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">Abdelwahab_Shandy</strong></blockquote><blockquote name="d93e" id="d93e" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong">AS_Cyber</strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/09e13b58f3a2"><time class="dt-published" datetime="2024-04-29T22:32:07.672Z">April 29, 2024</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/access-control-vulnerabilities-apprentice-user-role-controlled-by-request-parameter-09e13b58f3a2" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>