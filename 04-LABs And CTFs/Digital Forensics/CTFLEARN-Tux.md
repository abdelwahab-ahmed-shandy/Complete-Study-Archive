<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>CTFLEARN: Tux!</title><style>
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
<h1 class="p-name">CTFLEARN: Tux!</h1>
</header>
<section data-field="subtitle" class="p-summary">
Forensics
</section>
<section data-field="body" class="e-content">
<section name="91ac" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="b8e8" id="b8e8" class="graf graf--h3 graf--leading graf--title">CTFLEARN: Tux!</h3><p name="a57b" id="a57b" class="graf graf--p graf-after--h3"><strong class="markup--strong markup--p-strong">Forensics</strong></p><figure name="6dc6" id="6dc6" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*gotrRhftH0txF-avcCoDEQ.png" data-width="767" data-height="625" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*gotrRhftH0txF-avcCoDEQ.png"></figure><p name="46fb" id="46fb" class="graf graf--p graf-after--figure"><a href="https://ctflearn.com/challenge/973" data-href="https://ctflearn.com/challenge/973" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Challenge — Tux! — CTFlearn — CTF Practice — CTF Problems — CTF Challenges</a></p><p name="6a51" id="6a51" class="graf graf--p graf-after--p">The flag is hidden inside the Penguin! Solve this challenge before solving my 100 point Scope challenge which uses similar techniques as this one.</p><p name="5416" id="5416" class="graf graf--p graf-after--p">Don’t forget we always work inside VMs .</p><p name="c958" id="c958" class="graf graf--p graf-after--p">So we’ll upload the file there and then :</p><p name="d426" id="d426" class="graf graf--p graf-after--p">We took the download link and used <strong class="markup--strong markup--p-strong">wget </strong>to download the :</p><figure name="9303" id="9303" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*gS4S6Yye8sIc-l9RUGHOSw.png" data-width="681" data-height="370" src="https://cdn-images-1.medium.com/max/800/1*gS4S6Yye8sIc-l9RUGHOSw.png"></figure><p name="ae86" id="ae86" class="graf graf--p graf-after--figure">I always change the names to something that is closest to what we do, so I changed the name of the file to the name of the task that we are doing now , Now let’s get started :</p><figure name="7142" id="7142" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*SRy3PnHxgHWpmpRZWe_uyA.png" data-width="686" data-height="294" src="https://cdn-images-1.medium.com/max/800/1*SRy3PnHxgHWpmpRZWe_uyA.png"></figure><p name="3a81" id="3a81" class="graf graf--p graf-after--figure">I used file to find out the file type, and then I used exiftool, to make sure that this comment is correct, one way or another.</p><figure name="2ba7" id="2ba7" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*KFbfZ_hQ0ilvy-D7wnrFwA.png" data-width="683" data-height="195" src="https://cdn-images-1.medium.com/max/800/1*KFbfZ_hQ0ilvy-D7wnrFwA.png"></figure><p name="7efa" id="7efa" class="graf graf--p graf-after--figure">When I was sure I had to ask my brother for help <a href="https://cyberchef.org/" data-href="https://cyberchef.org/" class="markup--anchor markup--p-anchor" rel="nofollow noopener" target="_blank">https://cyberchef.org/</a></p><figure name="8637" id="8637" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*EY9ZOgP3jVb88-pB-XCGRA.png" data-width="880" data-height="323" src="https://cdn-images-1.medium.com/max/800/1*EY9ZOgP3jVb88-pB-XCGRA.png"></figure><p name="d2db" id="d2db" class="graf graf--p graf-after--figure">Okay, this is the password, but, why in the first place, there seems to be a hidden file in the back , It seems that there is a hidden file. Let’s try then, I will use binwalk :</p><figure name="961e" id="961e" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*5GEB951dz-B6QaZGxQj70Q.png" data-width="684" data-height="259" src="https://cdn-images-1.medium.com/max/800/1*5GEB951dz-B6QaZGxQj70Q.png"></figure><p name="7302" id="7302" class="graf graf--p graf-after--figure">Well we found a zip file already :</p><figure name="af0f" id="af0f" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*E54KaAhNMf6AubppPV-7LA.png" data-width="684" data-height="446" src="https://cdn-images-1.medium.com/max/800/1*E54KaAhNMf6AubppPV-7LA.png"></figure><p name="7374" id="7374" class="graf graf--p graf-after--figure">After extracting the file, I entered _Tux.jpg.extracted/, to find out what was inside it, then I determined the type of files ,It seems that file 1570 is what is meant :</p><figure name="58ec" id="58ec" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*D53aI_gvFE2Tk9lZNKjSzA.png" data-width="683" data-height="120" src="https://cdn-images-1.medium.com/max/800/1*D53aI_gvFE2Tk9lZNKjSzA.png"></figure><p name="d45e" id="d45e" class="graf graf--p graf-after--figure">We have set the password Linux12345, you must not forget it :</p><figure name="c01e" id="c01e" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*18HRAlZEc6xVPdbg4GZ5cw.png" data-width="574" data-height="350" src="https://cdn-images-1.medium.com/max/800/1*18HRAlZEc6xVPdbg4GZ5cw.png"></figure><p name="9ca8" id="9ca8" class="graf graf--p graf-after--figure">Then the flag was redirected to the flag , It was really fun .</p><blockquote name="b9b9" id="b9b9" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong">Here is the flag<br>See you soon in other reports….!!</strong></blockquote><blockquote name="8ce1" id="8ce1" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">Abdelwahab_Shandy</strong></blockquote><blockquote name="e89f" id="e89f" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong">AS_Cyber</strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/ab40ab24db9f"><time class="dt-published" datetime="2023-12-21T15:05:56.747Z">December 21, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/ctflearn-tux-ab40ab24db9f" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>