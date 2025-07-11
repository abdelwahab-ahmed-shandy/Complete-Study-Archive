<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>CTFLEARN:Chalkboard</title><style>
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
<h1 class="p-name">CTFLEARN:Chalkboard</h1>
</header>
<section data-field="subtitle" class="p-summary">
Forensics
</section>
<section data-field="body" class="e-content">
<section name="d654" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="e915" id="e915" class="graf graf--h3 graf--leading graf--title">CTFLEARN:Chalkboard</h3><p name="02f3" id="02f3" class="graf graf--p graf-after--h3"><strong class="markup--strong markup--p-strong">Forensics</strong></p><figure name="e6e1" id="e6e1" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*xO6MOsMyYokXCSkRNp_oUQ.png" data-width="758" data-height="620" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*xO6MOsMyYokXCSkRNp_oUQ.png"></figure><p name="873a" id="873a" class="graf graf--p graf-after--figure"><a href="https://ctflearn.com/challenge/972" data-href="https://ctflearn.com/challenge/972" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Challenge — Chalkboard — CTFlearn — CTF Practice — CTF Problems — CTF Challenges</a></p><p name="3a74" id="3a74" class="graf graf--p graf-after--p">Solve the equations embedded in the jpeg to find the flag. Solve this problem before solving my Scope challenge which is worth 100 points.</p><p name="d0a4" id="d0a4" class="graf graf--p graf-after--p"><a href="https://ctflearn.com/challenge/download/972" data-href="https://ctflearn.com/challenge/download/972" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">math.jpg</a></p><p name="dda6" id="dda6" class="graf graf--p graf-after--p">Don’t forget we always work inside VMs .</p><p name="2dfe" id="2dfe" class="graf graf--p graf-after--p">So we’ll upload the file there and then :</p><p name="fae4" id="fae4" class="graf graf--p graf-after--p">We took the download link and used <strong class="markup--strong markup--p-strong">wget </strong>to download the :</p><figure name="f452" id="f452" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*MTi5NB02LtrBrEcB2ZCHBQ.png" data-width="685" data-height="365" src="https://cdn-images-1.medium.com/max/800/1*MTi5NB02LtrBrEcB2ZCHBQ.png"></figure><p name="7ec3" id="7ec3" class="graf graf--p graf-after--figure">I always change the names to something that is closest to what we do, so I changed the name of the file to the name of the task that we are doing now , Now let’s get started :</p><figure name="c383" id="c383" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*s_UyU2u0JhDGjNi-XTbFrQ.png" data-width="682" data-height="290" src="https://cdn-images-1.medium.com/max/800/1*s_UyU2u0JhDGjNi-XTbFrQ.png"></figure><p name="9b5d" id="9b5d" class="graf graf--p graf-after--figure">Here we define the <strong class="markup--strong markup--p-strong">file </strong>type , There are a lot of interesting things :</p><figure name="26c1" id="26c1" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*6pkp3AQLRF9eV2se_b43Gg.png" data-width="684" data-height="130" src="https://cdn-images-1.medium.com/max/800/1*6pkp3AQLRF9eV2se_b43Gg.png"></figure><p name="323a" id="323a" class="graf graf--p graf-after--figure">I decided to use exif and exiftool:</p><figure name="585b" id="585b" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*oLYEeTO-McoHhA-_Rl3LMQ.png" data-width="681" data-height="533" src="https://cdn-images-1.medium.com/max/800/1*oLYEeTO-McoHhA-_Rl3LMQ.png"></figure><p name="e738" id="e738" class="graf graf--p graf-after--figure">We found this comment suspicious :</p><figure name="7300" id="7300" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*yV8UU81rEjIFrqUaUaa63Q.png" data-width="685" data-height="168" src="https://cdn-images-1.medium.com/max/800/1*yV8UU81rEjIFrqUaUaa63Q.png"></figure><p name="aa8a" id="aa8a" class="graf graf--p graf-after--figure">Let’s search using <strong class="markup--strong markup--p-strong">strings :</strong></p><figure name="efba" id="efba" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*RAyhRD_jpfI9nXA3dZ0lrA.png" data-width="684" data-height="262" src="https://cdn-images-1.medium.com/max/800/1*RAyhRD_jpfI9nXA3dZ0lrA.png"></figure><p name="e509" id="e509" class="graf graf--p graf-after--figure">It’s a math story , We have to solve it then :</p><p name="c697" id="c697" class="graf graf--p graf-after--p">When I substituted the two equations, I found that x = 2 and y = 5</p><figure name="dea0" id="dea0" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*q-msQeLzKEMCRllM-016dw.png" data-width="435" data-height="145" src="https://cdn-images-1.medium.com/max/800/1*q-msQeLzKEMCRllM-016dw.png"></figure><blockquote name="85dc" id="85dc" class="graf graf--blockquote graf-after--figure"><strong class="markup--strong markup--blockquote-strong">Here is the flag<br>See you soon in other reports….!!</strong></blockquote><blockquote name="a7da" id="a7da" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">Abdelwahab_Shandy</strong></blockquote><blockquote name="1885" id="1885" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong">AS_Cyber</strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/4ed998931f29"><time class="dt-published" datetime="2023-12-21T14:43:14.599Z">December 21, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/ctflearn-chalkboard-4ed998931f29" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>