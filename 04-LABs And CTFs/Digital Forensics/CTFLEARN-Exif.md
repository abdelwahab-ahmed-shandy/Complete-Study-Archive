<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>CTFLEARN:Exif</title><style>
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
<h1 class="p-name">CTFLEARN:Exif</h1>
</header>
<section data-field="subtitle" class="p-summary">
Forensics
</section>
<section data-field="body" class="e-content">
<section name="8eba" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="5a8d" id="5a8d" class="graf graf--h3 graf--leading graf--title">CTFLEARN:Exif</h3><p name="39cf" id="39cf" class="graf graf--p graf-after--h3"><strong class="markup--strong markup--p-strong">Forensics</strong></p><figure name="bfba" id="bfba" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*2TJvAFh8jUYJl8DgraCzxA.png" data-width="769" data-height="632" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*2TJvAFh8jUYJl8DgraCzxA.png"></figure><p name="e371" id="e371" class="graf graf--p graf-after--figure"><a href="https://ctflearn.com/challenge/303" data-href="https://ctflearn.com/challenge/303" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Challenge — Exif — CTFlearn — CTF Practice — CTF Problems — CTF Challenges</a></p><p name="3f48" id="3f48" class="graf graf--p graf-after--p">If only the password were in the image?</p><p name="9d33" id="9d33" class="graf graf--p graf-after--p"><a href="https://mega.nz/#!SDpF0aYC!fkkhBJuBBtBKGsLTDiF2NuLihP2WRd97Iynd3PhWqRw" data-href="https://mega.nz/#!SDpF0aYC!fkkhBJuBBtBKGsLTDiF2NuLihP2WRd97Iynd3PhWqRw" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">https://mega.nz/#!SDpF0aYC!fkkhBJuBBtBKGsLTDiF2NuLihP2WRd97Iynd3PhWqRw</a> You could really ‘own’ it with exif.</p><p name="d4bc" id="d4bc" class="graf graf--p graf-after--p">Don’t forget we always work inside VMs .</p><p name="347b" id="347b" class="graf graf--p graf-after--p">So we’ll upload the file there and then :</p><figure name="ce69" id="ce69" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*V7bIfdntHA4SNCU2p5VSoA.png" data-width="710" data-height="261" src="https://cdn-images-1.medium.com/max/800/1*V7bIfdntHA4SNCU2p5VSoA.png"></figure><p name="7c9d" id="7c9d" class="graf graf--p graf-after--figure">I always change the names to something that is closest to what we do, so I changed the name of the file to the name of the task that we are doing now. Now let’s get started :</p><figure name="92c6" id="92c6" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*FI0zymZo11mLNxtIxL9a7A.png" data-width="707" data-height="198" src="https://cdn-images-1.medium.com/max/800/1*FI0zymZo11mLNxtIxL9a7A.png"></figure><p name="025a" id="025a" class="graf graf--p graf-after--figure">Here we define the file type .</p><figure name="d28a" id="d28a" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*pbwQTdkSPb6BKH-lNZ2b1A.png" data-width="709" data-height="320" src="https://cdn-images-1.medium.com/max/800/1*pbwQTdkSPb6BKH-lNZ2b1A.png"></figure><p name="9d5d" id="9d5d" class="graf graf--p graf-after--figure">I used exif, but didn’t find anything interesting :</p><figure name="d617" id="d617" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*q1a5dAICSqoIh3JVrY2Rlg.png" data-width="708" data-height="214" src="https://cdn-images-1.medium.com/max/800/1*q1a5dAICSqoIh3JVrY2Rlg.png"></figure><p name="7a2f" id="7a2f" class="graf graf--p graf-after--figure">I used exiftool and it already found the flag :</p><figure name="54c1" id="54c1" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*9YYinOX0Ekzzi9a3pd0Bug.png" data-width="504" data-height="86" src="https://cdn-images-1.medium.com/max/800/1*9YYinOX0Ekzzi9a3pd0Bug.png"></figure><blockquote name="2ae5" id="2ae5" class="graf graf--blockquote graf-after--figure"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">Here is the flag<br>See you soon in other reports….!!</em></strong></blockquote><blockquote name="e50b" id="e50b" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">Abdelwahab_Shandy</em></strong></blockquote><blockquote name="6911" id="6911" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">AS_Cyber</em></strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/1b970cddf7d8"><time class="dt-published" datetime="2023-12-17T13:37:59.963Z">December 17, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/ctflearn-exif-1b970cddf7d8" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>