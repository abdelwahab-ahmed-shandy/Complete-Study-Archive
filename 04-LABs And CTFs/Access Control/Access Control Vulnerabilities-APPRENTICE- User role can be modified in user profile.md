<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>Access control vulnerabilities : APPRENTICE : User role can be modified in user profile</title><style>
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
<h1 class="p-name">Access control vulnerabilities : APPRENTICE : User role can be modified in user profile</h1>
</header>
<section data-field="subtitle" class="p-summary">
Web Security Academy &gt;&gt; Access control &gt;&gt; Lab
</section>
<section data-field="body" class="e-content">
<section name="db22" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="52a4" id="52a4" class="graf graf--h3 graf--leading graf--title">Access control vulnerabilities : APPRENTICE : User role can be modified in user profile</h3><p name="c5bd" id="c5bd" class="graf graf--p graf-after--h3"><a href="https://portswigger.net/web-security" data-href="https://portswigger.net/web-security" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Web Security Academy</a> &gt;&gt; <a href="https://portswigger.net/web-security/access-control" data-href="https://portswigger.net/web-security/access-control" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Access control</a> &gt;&gt; <a href="https://portswigger.net/web-security/access-control/lab-user-role-can-be-modified-in-user-profile" data-href="https://portswigger.net/web-security/access-control/lab-user-role-can-be-modified-in-user-profile" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Lab</a></p><figure name="a820" id="a820" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*95csJM7RwlH-bKfOOFKHZw.png" data-width="1193" data-height="483" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*95csJM7RwlH-bKfOOFKHZw.png"></figure><p name="c348" id="c348" class="graf graf--p graf-after--figure">The goal is to access the admin panel and use it to delete the user Carlos :</p><p name="58f2" id="58f2" class="graf graf--p graf-after--p">First, make burp run in the background, then log in using wiener:peter .</p><figure name="b4f7" id="b4f7" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*ecDTmejyccmz3J7dDJmZMQ.png" data-width="753" data-height="389" src="https://cdn-images-1.medium.com/max/800/1*ecDTmejyccmz3J7dDJmZMQ.png"></figure><p name="c749" id="c749" class="graf graf--p graf-after--figure">We need to try out what happens when using /admin , It seems I don’t have enough permissions , If you remember in the description that it is only accessible to users who are logged in using Role ID 2 , Therefore, we need to know what our permissions are on the site .</p><p name="d027" id="d027" class="graf graf--p graf-after--p">If we change the email of the user that I own, the request will be here post, because it is considered entering data into the server, and therefore in the response it will be clear to me what type of roleid it is.</p><figure name="ff68" id="ff68" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*0U5T1SgTk2_pTtjHMIh86g.png" data-width="1599" data-height="542" src="https://cdn-images-1.medium.com/max/800/1*0U5T1SgTk2_pTtjHMIh86g.png"></figure><p name="5b9f" id="5b9f" class="graf graf--p graf-after--figure">I have already changed my email address .</p><figure name="0315" id="0315" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*7wVHfgV824tgD51q1IQkLA.png" data-width="1029" data-height="657" src="https://cdn-images-1.medium.com/max/800/1*7wVHfgV824tgD51q1IQkLA.png"></figure><p name="ecb1" id="ecb1" class="graf graf--p graf-after--figure">Indeed, when I changed the email, the response was that the user, wiener, has a “roleid”: 1 , If so, we can change this by sending the roleid, with a request to change the email, as follows:</p><figure name="38cd" id="38cd" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*0Eng0DHZnpfAlEvz_1h_dA.png" data-width="821" data-height="213" src="https://cdn-images-1.medium.com/max/800/1*0Eng0DHZnpfAlEvz_1h_dA.png"></figure><p name="16fc" id="16fc" class="graf graf--p graf-after--figure">We will take the request and send it to Repeater .</p><figure name="678b" id="678b" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*RVE_7wpqK08ypc3OvYZLLg.png" data-width="598" data-height="595" src="https://cdn-images-1.medium.com/max/800/1*RVE_7wpqK08ypc3OvYZLLg.png"></figure><p name="493b" id="493b" class="graf graf--p graf-after--figure">You will add the “roleid”: 1, but instead of 1 you will make it 2 , to make the user wiener have higher permissions.</p><p name="34ec" id="34ec" class="graf graf--p graf-after--p">After that, you will send the request</p><figure name="4d5f" id="4d5f" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*K9vJ_lG5J49nHq5uURPuLA.png" data-width="1646" data-height="546" src="https://cdn-images-1.medium.com/max/800/1*K9vJ_lG5J49nHq5uURPuLA.png"><figcaption class="imageCaption">Congratulations, you solved the lab!</figcaption></figure><p name="26b7" id="26b7" class="graf graf--p graf-after--figure">Here we have reached the admin panel .</p><blockquote name="355e" id="355e" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">See you soon in other reports….!!</em></strong></blockquote><blockquote name="85cb" id="85cb" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">Abdelwahab_Shandy</em></strong></blockquote><blockquote name="26e1" id="26e1" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">AS_Cyber</em></strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/f3610002d21e"><time class="dt-published" datetime="2024-05-02T22:02:46.645Z">May 2, 2024</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/access-control-vulnerabilities-apprentice-user-role-can-be-modified-in-user-profile-f3610002d21e" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>