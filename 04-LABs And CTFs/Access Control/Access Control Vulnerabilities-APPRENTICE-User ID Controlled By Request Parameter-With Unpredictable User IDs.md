<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>Access control vulnerabilities : APPRENTICE : User ID controlled by request parameter, with…</title><style>
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
<h1 class="p-name">Access control vulnerabilities : APPRENTICE : User ID controlled by request parameter, with…</h1>
</header>
<section data-field="subtitle" class="p-summary">
Web Security Academy &gt;&gt;Access control &gt;&gt; Lab
</section>
<section data-field="body" class="e-content">
<section name="c284" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="08ec" id="08ec" class="graf graf--h3 graf--leading graf--title">Access control vulnerabilities : APPRENTICE : User ID controlled by request parameter, with unpredictable user IDs .</h3><p name="594e" id="594e" class="graf graf--p graf-after--h3"><a href="https://portswigger.net/web-security" data-href="https://portswigger.net/web-security" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Web Security Academy</a> &gt;&gt;<a href="https://portswigger.net/web-security/access-control" data-href="https://portswigger.net/web-security/access-control" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Access control</a> <a href="https://portswigger.net/web-security/access-control/lab-user-id-controlled-by-request-parameter-with-unpredictable-user-ids" data-href="https://portswigger.net/web-security/access-control/lab-user-id-controlled-by-request-parameter-with-unpredictable-user-ids" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">&gt;&gt; Lab</a></p><figure name="bc9d" id="bc9d" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*lQ_i9nwW3U6miR1GCUCelw.png" data-width="1232" data-height="533" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*lQ_i9nwW3U6miR1GCUCelw.png"></figure><p name="ba27" id="ba27" class="graf graf--p graf-after--figure">The goal here is to access Carlos’s API, so we have to access his GUIDs :</p><p name="106b" id="106b" class="graf graf--p graf-after--p">If, after collecting information before starting anything about this site, you will know that it is a blogs site more than anything that is just posts, and each post is written by a specific user. Therefore, you will find that the number of users is 3, and that each user actually has his own GUIDs. , So :</p><figure name="2d19" id="2d19" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*aASQ79jVG3yfb4nEm3Nlsw.png" data-width="1347" data-height="868" src="https://cdn-images-1.medium.com/max/800/1*aASQ79jVG3yfb4nEm3Nlsw.png"></figure><p name="f7e5" id="f7e5" class="graf graf--p graf-after--figure">When you browse around, you will find that each post has a specific ID .</p><p name="3bb5" id="3bb5" class="graf graf--p graf-after--p">So I will register the login using wiener:peter, then tell the userId from within the wiener user page, and will it really be the same as the user’s blogs?</p><figure name="3fd4" id="3fd4" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*1r4NYw-QaKgqkvpfm5sLlg.png" data-width="1600" data-height="566" src="https://cdn-images-1.medium.com/max/800/1*1r4NYw-QaKgqkvpfm5sLlg.png"><figcaption class="imageCaption">Same user id .</figcaption></figure><p name="8cf9" id="8cf9" class="graf graf--p graf-after--figure">Here inside the page for the user wiener .</p><figure name="667d" id="667d" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*UOruOt21ewKs-GQbtTA9Tg.png" data-width="1612" data-height="598" src="https://cdn-images-1.medium.com/max/800/1*UOruOt21ewKs-GQbtTA9Tg.png"><figcaption class="imageCaption">Same user id .</figcaption></figure><p name="d437" id="d437" class="graf graf--p graf-after--figure">Here inside the blogs .</p><p name="a926" id="a926" class="graf graf--p graf-after--p">So we can go back to the My Account page, and change the user ID :</p><figure name="28a9" id="28a9" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*wfCSvEJ_iyVtkH4HX8noSw.png" data-width="1361" data-height="458" src="https://cdn-images-1.medium.com/max/800/1*wfCSvEJ_iyVtkH4HX8noSw.png"></figure><p name="e448" id="e448" class="graf graf--p graf-after--figure">This is carlos’s user id , We found him by finding the post, and thus we found his user ID :</p><figure name="87c4" id="87c4" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*NChTYF47ge-kyJIXCvYodA.png" data-width="1585" data-height="544" src="https://cdn-images-1.medium.com/max/800/1*NChTYF47ge-kyJIXCvYodA.png"></figure><p name="f6dd" id="f6dd" class="graf graf--p graf-after--figure">We will change the user ID from here, and test whether it will actually take me to Carlos’s page .</p><figure name="75b0" id="75b0" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*PbiKCW8q8zx2SANz9MttgQ.png" data-width="1587" data-height="556" src="https://cdn-images-1.medium.com/max/800/1*PbiKCW8q8zx2SANz9MttgQ.png"></figure><p name="a4e5" id="a4e5" class="graf graf--p graf-after--figure">Indeed, what was expected happened and I arrived at Carlos’s page .</p><figure name="ee4e" id="ee4e" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*AL-M_QNofisbVVaDPASAqw.png" data-width="997" data-height="592" src="https://cdn-images-1.medium.com/max/800/1*AL-M_QNofisbVVaDPASAqw.png"><figcaption class="imageCaption">Congratulations, you solved the lab!</figcaption></figure><p name="94f2" id="94f2" class="graf graf--p graf-after--figure">We can also do all this using burp. Try it, it will be really fun .</p><blockquote name="0357" id="0357" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">See you soon in other reports….!!</em></strong></blockquote><blockquote name="6aa7" id="6aa7" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">Abdelwahab_Shandy</em></strong></blockquote><blockquote name="e385" id="e385" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">AS_Cyber</em></strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/087efd47a0ae"><time class="dt-published" datetime="2024-05-02T23:11:40.296Z">May 2, 2024</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/access-control-vulnerabilities-apprentice-user-id-controlled-by-request-parameter-with-087efd47a0ae" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>