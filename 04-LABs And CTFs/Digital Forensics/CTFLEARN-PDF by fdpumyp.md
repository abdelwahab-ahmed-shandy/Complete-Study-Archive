<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>CTFLEARN:PDF by fdpumyp</title><style>
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
<h1 class="p-name">CTFLEARN:PDF by fdpumyp</h1>
</header>
<section data-field="subtitle" class="p-summary">
Forensics
</section>
<section data-field="body" class="e-content">
<section name="9868" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="9324" id="9324" class="graf graf--h3 graf--leading graf--title">CTFLEARN:PDF by fdpumyp</h3><p name="d4a5" id="d4a5" class="graf graf--p graf-after--h3"><strong class="markup--strong markup--p-strong">Forensics</strong></p><figure name="7eb2" id="7eb2" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*oMSdnK31ILgjsnu8BgSW1w.png" data-width="785" data-height="623" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*oMSdnK31ILgjsnu8BgSW1w.png"></figure><p name="1057" id="1057" class="graf graf--p graf-after--figure"><a href="https://ctflearn.com/challenge/957" data-href="https://ctflearn.com/challenge/957" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Challenge — PDF by fdpumyp — CTFlearn — CTF Practice — CTF Problems — CTF Challenges</a></p><p name="456e" id="456e" class="graf graf--p graf-after--p">Hi, just as we talked during a break, you have this file here and check if something is wrong with it. That’s the only thing we found strange with this suspect, I hope there will be a password for his external drive</p><p name="0e45" id="0e45" class="graf graf--p graf-after--p">Bye</p><p name="3fb1" id="3fb1" class="graf graf--p graf-after--p">Don’t forget we always work inside VMs .</p><p name="d446" id="d446" class="graf graf--p graf-after--p">So we’ll upload the file there and then :</p><p name="c103" id="c103" class="graf graf--p graf-after--p">We took the download link and used <strong class="markup--strong markup--p-strong">wget </strong>to download the :</p><figure name="da6f" id="da6f" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*pFoUcSDCnOV1M6fmfH97Jw.png" data-width="682" data-height="227" src="https://cdn-images-1.medium.com/max/800/1*pFoUcSDCnOV1M6fmfH97Jw.png"></figure><p name="6119" id="6119" class="graf graf--p graf-after--figure">I always change the names to something that is closest to what we do, so I changed the name of the file to the name of the task that we are doing now , Now let’s get started :</p><figure name="d0e9" id="d0e9" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*k6H_CMsOrj_Ax_UdZQYi9A.png" data-width="564" data-height="151" src="https://cdn-images-1.medium.com/max/800/1*k6H_CMsOrj_Ax_UdZQYi9A.png"></figure><p name="2ffc" id="2ffc" class="graf graf--p graf-after--figure">Here we define the <strong class="markup--strong markup--p-strong">file </strong>type , There are a lot of interesting things :</p><figure name="f785" id="f785" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*LLGtMK8xW55D0bBN9-KyeQ.png" data-width="332" data-height="62" src="https://cdn-images-1.medium.com/max/800/1*LLGtMK8xW55D0bBN9-KyeQ.png"></figure><p name="269f" id="269f" class="graf graf--p graf-after--figure">I decided to use exif and exiftool , Nothing important</p><figure name="f29b" id="f29b" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*tLCzKarJleBy9w_RdkEngQ.png" data-width="464" data-height="365" src="https://cdn-images-1.medium.com/max/800/1*tLCzKarJleBy9w_RdkEngQ.png"></figure><p name="e597" id="e597" class="graf graf--p graf-after--figure">Let’s search using <strong class="markup--strong markup--p-strong">strings :</strong></p><figure name="d3a2" id="d3a2" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*0HW0o5U5UfXrQuQR9kuHwA.png" data-width="429" data-height="504" src="https://cdn-images-1.medium.com/max/800/1*0HW0o5U5UfXrQuQR9kuHwA.png"></figure><p name="ed91" id="ed91" class="graf graf--p graf-after--figure">With the use of strings, at the end of the file I found some information :</p><figure name="c2ab" id="c2ab" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*gUTcV1uckQlm5A9jJ7lyTg.png" data-width="683" data-height="530" src="https://cdn-images-1.medium.com/max/800/1*gUTcV1uckQlm5A9jJ7lyTg.png"></figure><p name="6b97" id="6b97" class="graf graf--p graf-after--figure">I took this, and searched it on <a href="https://cyberchef.org/" data-href="https://cyberchef.org/" class="markup--anchor markup--p-anchor" rel="nofollow noopener" target="_blank">https://cyberchef.org/</a></p><figure name="84c2" id="84c2" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*tamE1UDCoNZVLJIsia2B1A.png" data-width="366" data-height="82" src="https://cdn-images-1.medium.com/max/800/1*tamE1UDCoNZVLJIsia2B1A.png"></figure><figure name="54e2" id="54e2" class="graf graf--figure graf-after--figure"><img class="graf-image" data-image-id="1*HKTokvluheb4Z_kvp_6O9g.png" data-width="766" data-height="357" src="https://cdn-images-1.medium.com/max/800/1*HKTokvluheb4Z_kvp_6O9g.png"></figure><p name="5bb5" id="5bb5" class="graf graf--p graf-after--figure"><strong class="markup--strong markup--p-strong"><em class="markup--em markup--p-em">Here is the flag</em></strong></p><figure name="2d86" id="2d86" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*AfvS0SD4MNiJht6vRyUmzw.png" data-width="518" data-height="69" src="https://cdn-images-1.medium.com/max/800/1*AfvS0SD4MNiJht6vRyUmzw.png"></figure><blockquote name="708d" id="708d" class="graf graf--blockquote graf-after--figure"><strong class="markup--strong markup--blockquote-strong">See you soon in other reports….!!</strong></blockquote><blockquote name="9825" id="9825" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">Abdelwahab_Shandy</strong></blockquote><blockquote name="dbb4" id="dbb4" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong">AS_Cyber</strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/67b8a32808d2"><time class="dt-published" datetime="2023-12-21T16:44:12.552Z">December 21, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/ctflearn-pdf-by-fdpumyp-67b8a32808d2" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>