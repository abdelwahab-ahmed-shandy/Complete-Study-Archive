<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>CTFLEARN:Forensics 101</title><style>
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
<h1 class="p-name">CTFLEARN:Forensics 101</h1>
</header>
<section data-field="subtitle" class="p-summary">
Forensics
</section>
<section data-field="body" class="e-content">
<section name="83a3" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="aa9e" id="aa9e" class="graf graf--h3 graf--leading graf--title">CTFLEARN:Forensics 101</h3><p name="e6b2" id="e6b2" class="graf graf--p graf-after--h3">Forensics</p><figure name="a2c6" id="a2c6" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*IFkTbVWa7jLN2UKnQB0lfQ.png" data-width="764" data-height="625" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*IFkTbVWa7jLN2UKnQB0lfQ.png"><figcaption class="imageCaption">Forensics 101</figcaption></figure><p name="7b20" id="7b20" class="graf graf--p graf-after--figure"><a href="https://ctflearn.com/challenge/96" data-href="https://ctflearn.com/challenge/96" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Challenge — Forensics 101 — CTFlearn — CTF Practice — CTF Problems — CTF Challenges</a></p><p name="c554" id="c554" class="graf graf--p graf-after--p">Think the flag is somewhere in there. Would you help me find it? <a href="https://mega.nz/#!OHohCbTa!wbg60PARf4u6E6juuvK9-aDRe_bgEL937VO01EImM7c" data-href="https://mega.nz/#!OHohCbTa!wbg60PARf4u6E6juuvK9-aDRe_bgEL937VO01EImM7c" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">https://mega.nz/#!OHohCbTa!wbg60PARf4u6E6juuvK9-aDRe_bgEL937VO01EImM7c</a></p><p name="ab5d" id="ab5d" class="graf graf--p graf-after--p">Don’t forget we always work inside VMs .</p><p name="9952" id="9952" class="graf graf--p graf-after--p">So we’ll upload the file there and then :</p><figure name="e3f1" id="e3f1" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*FfCaAnKGotsSCYFSXP-F4Q.png" data-width="706" data-height="249" src="https://cdn-images-1.medium.com/max/800/1*FfCaAnKGotsSCYFSXP-F4Q.png"></figure><p name="384a" id="384a" class="graf graf--p graf-after--figure">I always change the names to something that is closest to what we do, so I changed the name of the file to the name of the task that we are doing now. Now let’s get started.</p><figure name="3af7" id="3af7" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*ec6dKGQarLFlgo-HU3Hbuw.png" data-width="710" data-height="187" src="https://cdn-images-1.medium.com/max/800/1*ec6dKGQarLFlgo-HU3Hbuw.png"></figure><p name="ad89" id="ad89" class="graf graf--p graf-after--figure">Here we define the file type .</p><figure name="0d81" id="0d81" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*68IWxwoIs_-ZL_VaY3fzSA.png" data-width="666" data-height="469" src="https://cdn-images-1.medium.com/max/800/1*68IWxwoIs_-ZL_VaY3fzSA.png"></figure><p name="cecd" id="cecd" class="graf graf--p graf-after--figure">I used some tools such as exif and exiftool ,But I didn’t find anything interesting .</p><figure name="0bb7" id="0bb7" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*dR4ac1bG4nVO63lgYhh2kw.png" data-width="709" data-height="257" src="https://cdn-images-1.medium.com/max/800/1*dR4ac1bG4nVO63lgYhh2kw.png"></figure><p name="40b6" id="40b6" class="graf graf--p graf-after--figure">Here I decided to use strings , I have already found the flag :</p><figure name="7dad" id="7dad" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*R8VLsT1mscuKWJQzoedNOg.png" data-width="370" data-height="86" src="https://cdn-images-1.medium.com/max/800/1*R8VLsT1mscuKWJQzoedNOg.png"></figure><blockquote name="9cb8" id="9cb8" class="graf graf--blockquote graf-after--figure"><strong class="markup--strong markup--blockquote-strong">Here is the flag<br>See you soon in other reports….!!</strong></blockquote><blockquote name="0c7e" id="0c7e" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">Abdelwahab_Shandy</strong></blockquote><blockquote name="eb60" id="eb60" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong">AS_Cyber</strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/3d0b686b70e0"><time class="dt-published" datetime="2023-12-17T13:10:01.692Z">December 17, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/ctflearn-forensics-101-3d0b686b70e0" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>