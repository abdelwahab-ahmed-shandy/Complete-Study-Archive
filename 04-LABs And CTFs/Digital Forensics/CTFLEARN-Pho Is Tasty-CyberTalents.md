<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>CTFLEARN:Pho Is Tasty!</title><style>
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
<h1 class="p-name">CTFLEARN:Pho Is Tasty!</h1>
</header>
<section data-field="subtitle" class="p-summary">
Forensics
</section>
<section data-field="body" class="e-content">
<section name="1a06" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="4965" id="4965" class="graf graf--h3 graf--leading graf--title">CTFLEARN:Pho Is Tasty!</h3><p name="4319" id="4319" class="graf graf--p graf-after--h3"><strong class="markup--strong markup--p-strong">Forensics</strong></p><figure name="4fac" id="4fac" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*jJ28jz2DUG8DbsN3pc7yQg.png" data-width="777" data-height="632" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*jJ28jz2DUG8DbsN3pc7yQg.png"></figure><p name="a4b3" id="a4b3" class="graf graf--p graf-after--figure"><a href="https://ctflearn.com/challenge/971" data-href="https://ctflearn.com/challenge/971" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Challenge — Pho Is Tasty! — CTFlearn — CTF Practice — CTF Problems — CTF Challenges</a></p><p name="3b47" id="3b47" class="graf graf--p graf-after--p">The flag is hidden in the jpeg file. Good Luck! Have some Pho! Solve this challenge before solving my Scope challenge for 100 points.</p><p name="69ec" id="69ec" class="graf graf--p graf-after--p">Don’t forget we always work inside VMs .</p><p name="9840" id="9840" class="graf graf--p graf-after--p">So we’ll upload the file there and then :</p><p name="a8df" id="a8df" class="graf graf--p graf-after--p">We took the download link and used <strong class="markup--strong markup--p-strong">wget </strong>to download the :</p><figure name="9926" id="9926" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*ntlzkf300Nhr4AU7cIvUPA.png" data-width="683" data-height="338" src="https://cdn-images-1.medium.com/max/800/1*ntlzkf300Nhr4AU7cIvUPA.png"></figure><p name="07a9" id="07a9" class="graf graf--p graf-after--figure">I always change the names to something that is closest to what we do, so I changed the name of the file to the name of the task that we are doing now , Now let’s get started :</p><figure name="40dc" id="40dc" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*LtvPLj6GwGpt8ZelIcD3tA.png" data-width="682" data-height="247" src="https://cdn-images-1.medium.com/max/800/1*LtvPLj6GwGpt8ZelIcD3tA.png"></figure><p name="e019" id="e019" class="graf graf--p graf-after--figure">Here we define the <strong class="markup--strong markup--p-strong">file </strong>type , There are a lot of interesting things :</p><figure name="a7af" id="a7af" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*tjFgkrcpHEdev6cesSUmaQ.png" data-width="683" data-height="102" src="https://cdn-images-1.medium.com/max/800/1*tjFgkrcpHEdev6cesSUmaQ.png"></figure><p name="40a1" id="40a1" class="graf graf--p graf-after--figure">I decided to use exif and exiftool, but no positive result :</p><figure name="b5ee" id="b5ee" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*YHTrBnf74IosCiCVsvcEGQ.png" data-width="685" data-height="492" src="https://cdn-images-1.medium.com/max/800/1*YHTrBnf74IosCiCVsvcEGQ.png"></figure><p name="8cbe" id="8cbe" class="graf graf--p graf-after--figure">Let’s search using <strong class="markup--strong markup--p-strong">strings :</strong></p><figure name="41dd" id="41dd" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*KlbRTxnW1bISJT_ooC5-sg.png" data-width="686" data-height="483" src="https://cdn-images-1.medium.com/max/800/1*KlbRTxnW1bISJT_ooC5-sg.png"></figure><p name="4309" id="4309" class="graf graf--p graf-after--figure">Also binwalk, nothing useful came out :</p><figure name="f368" id="f368" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*YNvRMPiLR2u2Mjur2ai6Fg.png" data-width="583" data-height="123" src="https://cdn-images-1.medium.com/max/800/1*YNvRMPiLR2u2Mjur2ai6Fg.png"></figure><p name="6fb3" id="6fb3" class="graf graf--p graf-after--figure">I decided to enlist the help of a man with hexdump, to find a solution</p><figure name="a884" id="a884" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*UUc0j1YK1sDPuxY1NqYmOg.png" data-width="411" data-height="69" src="https://cdn-images-1.medium.com/max/800/1*UUc0j1YK1sDPuxY1NqYmOg.png"></figure><p name="9338" id="9338" class="graf graf--p graf-after--figure">Finally it seems to be the solution :</p><figure name="46a4" id="46a4" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*ODGd5o350VuHtF3n6H5KFg.png" data-width="684" data-height="158" src="https://cdn-images-1.medium.com/max/800/1*ODGd5o350VuHtF3n6H5KFg.png"></figure><p name="4e14" id="4e14" class="graf graf--p graf-after--figure">Here is the flag</p><figure name="6fa4" id="6fa4" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*f8Q5K71xdghX5K7Pe0j0-A.png" data-width="683" data-height="200" src="https://cdn-images-1.medium.com/max/800/1*f8Q5K71xdghX5K7Pe0j0-A.png"></figure><p name="3a84" id="3a84" class="graf graf--p graf-after--figure">..C..T..F..l..e..a..r..n..{..I.._..L..o..v..e._..P..h..o..!..!..!..}.</p><p name="58ae" id="58ae" class="graf graf--p graf-after--p">It’s not that easy, take out the flasher correctly??</p><blockquote name="1266" id="1266" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong">See you soon in other reports….!!</strong></blockquote><blockquote name="dd04" id="dd04" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">Abdelwahab_Shandy</strong></blockquote><blockquote name="21a9" id="21a9" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong">AS_Cyber</strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/2834ba628940"><time class="dt-published" datetime="2023-12-21T15:30:35.608Z">December 21, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/ctflearn-pho-is-tasty-2834ba628940" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>