<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>Digital Forensics:I love images</title><style>
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
<h1 class="p-name">Digital Forensics:I love images</h1>
</header>
<section data-field="subtitle" class="p-summary">
cybertalents
</section>
<section data-field="body" class="e-content">
<section name="d625" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="79ee" id="79ee" class="graf graf--h3 graf--leading graf--title">Digital Forensics:I love images</h3><p name="2b4d" id="2b4d" class="graf graf--p graf-after--h3">cybertalents</p><figure name="d59c" id="d59c" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*3cyBZvKBrUELP5hkilduRA.png" data-width="975" data-height="595" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*3cyBZvKBrUELP5hkilduRA.png"></figure><p name="ae0b" id="ae0b" class="graf graf--p graf-after--figure">A hacker left us something that allows us to track him in this image, can you find it?</p><p name="978a" id="978a" class="graf graf--p graf-after--p">First we have to download the file using wget:</p><figure name="9eea" id="9eea" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*Ncp6341NMVJFwOlFp9Nwzw.png" data-width="1141" data-height="524" src="https://cdn-images-1.medium.com/max/800/1*Ncp6341NMVJFwOlFp9Nwzw.png"></figure><p name="8dd3" id="8dd3" class="graf graf--p graf-after--figure">We now have to know the file type :</p><figure name="1b88" id="1b88" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*l0G-mTVIHFoqZ6RfMF8CSQ.png" data-width="975" data-height="130" src="https://cdn-images-1.medium.com/max/800/1*l0G-mTVIHFoqZ6RfMF8CSQ.png"></figure><p name="05e5" id="05e5" class="graf graf--p graf-after--figure">I tried using both exif and exiftool:</p><figure name="9d2e" id="9d2e" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*hu7maBRP18i7VMZB1re3Kw.png" data-width="975" data-height="598" src="https://cdn-images-1.medium.com/max/800/1*hu7maBRP18i7VMZB1re3Kw.png"></figure><p name="a1fd" id="a1fd" class="graf graf--p graf-after--figure">It didn’t work so I used strings:</p><figure name="94e8" id="94e8" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*H0zJeOo0HtO0CZ0gOJeILw.png" data-width="975" data-height="409" src="https://cdn-images-1.medium.com/max/800/1*H0zJeOo0HtO0CZ0gOJeILw.png"></figure><p name="7c31" id="7c31" class="graf graf--p graf-after--figure">Finally found this line for it , I thought it was science, but it wasn’t, so .</p><figure name="273f" id="273f" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*je4989iCKpSaIOl5P8gFhQ.png" data-width="975" data-height="233" src="https://cdn-images-1.medium.com/max/800/1*je4989iCKpSaIOl5P8gFhQ.png"></figure><p name="9e84" id="9e84" class="graf graf--p graf-after--figure">I tried both base64 and base32, base32 succeeded in outputting the required flag ,</p><figure name="8823" id="8823" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*atU8JurEIXjUaN26z6A4SQ.png" data-width="1051" data-height="242" src="https://cdn-images-1.medium.com/max/800/1*atU8JurEIXjUaN26z6A4SQ.png"></figure><p name="ecd6" id="ecd6" class="graf graf--p graf-after--figure">Here I used cyberchef.org, and you can also use command lines to output the flag, by using :</p><figure name="e329" id="e329" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*yZx78RGoiuqBbfvRh0wuMg.png" data-width="701" data-height="123" src="https://cdn-images-1.medium.com/max/800/1*yZx78RGoiuqBbfvRh0wuMg.png"></figure><p name="7797" id="7797" class="graf graf--p graf-after--figure">Really, flag is not always base64 .</p><blockquote name="caac" id="caac" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">See you soon in other reports….!!</em></strong></blockquote><blockquote name="2774" id="2774" class="graf graf--blockquote graf-after--blockquote">Abdelwahab_Shandy</blockquote><blockquote name="8fc7" id="8fc7" class="graf graf--blockquote graf-after--blockquote graf--trailing">AS_Cyber</blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/7846be0c1a93"><time class="dt-published" datetime="2023-12-06T23:28:37.938Z">December 6, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/digital-forensics-i-love-images-7846be0c1a93" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>