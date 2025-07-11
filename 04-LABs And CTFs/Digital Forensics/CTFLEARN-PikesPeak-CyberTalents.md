<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>CTFLEARN:PikesPeak</title><style>
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
<h1 class="p-name">CTFLEARN:PikesPeak</h1>
</header>
<section data-field="subtitle" class="p-summary">
Forensics
</section>
<section data-field="body" class="e-content">
<section name="9c53" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="accd" id="accd" class="graf graf--h3 graf--leading graf--title">CTFLEARN:PikesPeak</h3><p name="298d" id="298d" class="graf graf--p graf-after--h3"><strong class="markup--strong markup--p-strong">Forensics</strong></p><figure name="a935" id="a935" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*H6P5qN5CmICX178TM6XZLA.png" data-width="814" data-height="628" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*H6P5qN5CmICX178TM6XZLA.png"></figure><p name="0261" id="0261" class="graf graf--p graf-after--figure"><a href="https://ctflearn.com/challenge/935" data-href="https://ctflearn.com/challenge/935" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Challenge — PikesPeak — CTFlearn — CTF Practice — CTF Problems — CTF Challenges</a></p><p name="5807" id="5807" class="graf graf--p graf-after--p">Pay attention to those strings!</p><p name="1379" id="1379" class="graf graf--p graf-after--p"><a href="https://ctflearn.com/challenge/download/935" data-href="https://ctflearn.com/challenge/download/935" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">PikesPeak.jpg</a></p><p name="e1b8" id="e1b8" class="graf graf--p graf-after--p">Don’t forget we always work inside VMs .</p><p name="75bc" id="75bc" class="graf graf--p graf-after--p">So we’ll upload the file there and then :</p><p name="3ed6" id="3ed6" class="graf graf--p graf-after--p">We took the download link and used <strong class="markup--strong markup--p-strong">wget </strong>to download the :</p><figure name="955b" id="955b" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*cg-Sk-ak3Qowy7r-60KxBA.png" data-width="683" data-height="353" src="https://cdn-images-1.medium.com/max/800/1*cg-Sk-ak3Qowy7r-60KxBA.png"></figure><p name="844f" id="844f" class="graf graf--p graf-after--figure">I always change the names to something that is closest to what we do, so I changed the name of the file to the name of the task that we are doing now , Now let’s get started :</p><figure name="f77a" id="f77a" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*OmxdcDNdSl_EXhCylVTshw.png" data-width="683" data-height="301" src="https://cdn-images-1.medium.com/max/800/1*OmxdcDNdSl_EXhCylVTshw.png"></figure><p name="40b9" id="40b9" class="graf graf--p graf-after--figure">Here we define the <strong class="markup--strong markup--p-strong">file </strong>type , There are a lot of interesting things :</p><figure name="cbe8" id="cbe8" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*834rzd879HNxAx-GotbN0g.png" data-width="683" data-height="224" src="https://cdn-images-1.medium.com/max/800/1*834rzd879HNxAx-GotbN0g.png"></figure><p name="cfc6" id="cfc6" class="graf graf--p graf-after--figure">If you notice, you will find a number of many comments here .</p><p name="80ea" id="80ea" class="graf graf--p graf-after--p">I decided to use exif and exiftool. We found a comment, but I don’t think it’s the flag.</p><figure name="0abd" id="0abd" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*QMs925MVGaQqQQRKShE76w.png" data-width="684" data-height="533" src="https://cdn-images-1.medium.com/max/800/1*QMs925MVGaQqQQRKShE76w.png"></figure><p name="8c47" id="8c47" class="graf graf--p graf-after--figure">Let’s search using <strong class="markup--strong markup--p-strong">strings :</strong></p><figure name="233a" id="233a" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*cGmtNFNf-mXzynyVOIUn1g.png" data-width="684" data-height="534" src="https://cdn-images-1.medium.com/max/800/1*cGmtNFNf-mXzynyVOIUn1g.png"></figure><p name="4669" id="4669" class="graf graf--p graf-after--figure">We found a group of flags, we have to find out which one of them is correct .</p><p name="9192" id="9192" class="graf graf--p graf-after--p">If we go back to the CTFs, the other ones we played before, we find that the first letter in the flag is CTFlearn.</p><figure name="15b4" id="15b4" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*EA1V5uOm3y7H5XOW6nj_aA.png" data-width="406" data-height="103" src="https://cdn-images-1.medium.com/max/800/1*EA1V5uOm3y7H5XOW6nj_aA.png"></figure><blockquote name="33e6" id="33e6" class="graf graf--blockquote graf-after--figure"><strong class="markup--strong markup--blockquote-strong">Here is the flag<br>See you soon in other reports….!!</strong></blockquote><blockquote name="841d" id="841d" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">Abdelwahab_Shandy</strong></blockquote><blockquote name="41f1" id="41f1" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong">AS_Cyber</strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/ea4096dc0035"><time class="dt-published" datetime="2023-12-21T14:24:56.359Z">December 21, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/ctflearn-pikespeak-ea4096dc0035" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>