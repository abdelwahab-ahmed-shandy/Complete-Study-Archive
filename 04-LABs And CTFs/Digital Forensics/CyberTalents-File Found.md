<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>Digital Forensics : File Found</title><style>
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
<h1 class="p-name">Digital Forensics : File Found</h1>
</header>
<section data-field="subtitle" class="p-summary">
cybertalents
</section>
<section data-field="body" class="e-content">
<section name="eca9" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="42aa" id="42aa" class="graf graf--h3 graf--leading graf--title">Digital Forensics : File Found</h3><p name="ba7d" id="ba7d" class="graf graf--p graf-after--h3">cybertalents</p><figure name="4b13" id="4b13" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*1fX2wFxTGwdudrr3zisYlQ.png" data-width="980" data-height="537" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*1fX2wFxTGwdudrr3zisYlQ.png"></figure><p name="fbe6" id="fbe6" class="graf graf--p graf-after--figure">First we have to download the file using wget:</p><figure name="2ed2" id="2ed2" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*-pP0oBVTbeiiRWBV7v166A.png" data-width="907" data-height="343" src="https://cdn-images-1.medium.com/max/800/1*-pP0oBVTbeiiRWBV7v166A.png"></figure><p name="b640" id="b640" class="graf graf--p graf-after--figure">The first file type had to be known :</p><figure name="cb10" id="cb10" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*fTSebhniDoprO4T2qJq4Kw.png" data-width="554" data-height="110" src="https://cdn-images-1.medium.com/max/800/1*fTSebhniDoprO4T2qJq4Kw.png"></figure><p name="1c48" id="1c48" class="graf graf--p graf-after--figure">I tried to read the file to find out the content, but it was like this :</p><figure name="0300" id="0300" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*NFEXwEfdgCDcy4DEX_T1pg.png" data-width="902" data-height="472" src="https://cdn-images-1.medium.com/max/800/1*NFEXwEfdgCDcy4DEX_T1pg.png"></figure><p name="95e3" id="95e3" class="graf graf--p graf-after--figure">I decided to use strings</p><figure name="6c97" id="6c97" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*6bJHcE5dzU6ooHb1BDkgqA.png" data-width="587" data-height="418" src="https://cdn-images-1.medium.com/max/800/1*6bJHcE5dzU6ooHb1BDkgqA.png"></figure><p name="ee68" id="ee68" class="graf graf--p graf-after--figure">I found this line and it seems that it ends the flag.</p><p name="73fa" id="73fa" class="graf graf--p graf-after--p">After research, it seemed that the flag had been changed with Caesar Cipher, and we had to restore it as it was before :</p><figure name="0527" id="0527" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*hhhhVjmKT9hzK-SXwq7xRA.png" data-width="858" data-height="484" src="https://cdn-images-1.medium.com/max/800/1*hhhhVjmKT9hzK-SXwq7xRA.png"></figure><p name="8b0a" id="8b0a" class="graf graf--p graf-after--figure">I changed the key here several times, until I reached the correct number, which was 13</p><blockquote name="8223" id="8223" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong">See you soon in other reports….!!</strong></blockquote><blockquote name="fbd3" id="fbd3" class="graf graf--blockquote graf-after--blockquote">Abdelwahab_Shandy</blockquote><blockquote name="49db" id="49db" class="graf graf--blockquote graf-after--blockquote graf--trailing">AS_Cyber</blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/3924f1071d61"><time class="dt-published" datetime="2023-12-06T23:53:42.727Z">December 6, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/digital-forensics-file-found-3924f1071d61" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>