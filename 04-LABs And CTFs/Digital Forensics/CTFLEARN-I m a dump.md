<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>CTFLEARN:I’m a dump</title><style>
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
<h1 class="p-name">CTFLEARN:I’m a dump</h1>
</header>
<section data-field="subtitle" class="p-summary">
Forensics
</section>
<section data-field="body" class="e-content">
<section name="4fdc" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="bca0" id="bca0" class="graf graf--h3 graf--leading graf--title">CTFLEARN:I’m a dump</h3><p name="e302" id="e302" class="graf graf--p graf-after--h3"><strong class="markup--strong markup--p-strong">Forensics</strong></p><figure name="c3bc" id="c3bc" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*Riyp-hoc0QaBx8vIKjzIHw.png" data-width="763" data-height="618" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*Riyp-hoc0QaBx8vIKjzIHw.png"></figure><p name="99ee" id="99ee" class="graf graf--p graf-after--figure"><a href="https://ctflearn.com/challenge/883" data-href="https://ctflearn.com/challenge/883" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Challenge — I’m a dump — CTFlearn — CTF Practice — CTF Problems — CTF Challenges</a></p><p name="cfb5" id="cfb5" class="graf graf--p graf-after--p">The keyword is hexadecimal, and removing an useless H.E.H.U.H.E. from the flag. The flag is in the format CTFlearn{*}</p><p name="25b1" id="25b1" class="graf graf--p graf-after--p"><a href="https://ctflearn.com/challenge/download/883" data-href="https://ctflearn.com/challenge/download/883" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">file</a></p><p name="8f47" id="8f47" class="graf graf--p graf-after--p">Don’t forget we always work inside VMs .</p><p name="c923" id="c923" class="graf graf--p graf-after--p">So we’ll upload the file there and then :</p><p name="7025" id="7025" class="graf graf--p graf-after--p">We took the download link and used <strong class="markup--strong markup--p-strong">wget </strong>to download the :</p><figure name="2793" id="2793" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*8IHyGo5gHNgxEhCE4XXLyQ.png" data-width="552" data-height="333" src="https://cdn-images-1.medium.com/max/800/1*8IHyGo5gHNgxEhCE4XXLyQ.png"></figure><p name="226f" id="226f" class="graf graf--p graf-after--figure">I always change the names to something that is closest to what we do, so I changed the name of the file to the name of the task that we are doing now , Now let’s get started :</p><figure name="199a" id="199a" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*5g2fV9v2m-ykjbGk7ReYvA.png" data-width="552" data-height="243" src="https://cdn-images-1.medium.com/max/800/1*5g2fV9v2m-ykjbGk7ReYvA.png"></figure><p name="e654" id="e654" class="graf graf--p graf-after--figure">Here we define the <strong class="markup--strong markup--p-strong">file </strong>type , There are a lot of interesting things :</p><figure name="e7a1" id="e7a1" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*_GUF-UUiyZ3dp9kR3qN3ug.png" data-width="692" data-height="110" src="https://cdn-images-1.medium.com/max/800/1*_GUF-UUiyZ3dp9kR3qN3ug.png"></figure><p name="1891" id="1891" class="graf graf--p graf-after--figure">Let’s search using <strong class="markup--strong markup--p-strong">strings :</strong></p><figure name="a1e4" id="a1e4" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*WtZBiKfgYCbhEHydy_FV8A.png" data-width="428" data-height="503" src="https://cdn-images-1.medium.com/max/800/1*WtZBiKfgYCbhEHydy_FV8A.png"></figure><p name="f2a9" id="f2a9" class="graf graf--p graf-after--figure">Well, I read the file using cat. I already found the flag, but we will need to delete some of the visible letters, such as H, E, and U.</p><figure name="d534" id="d534" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*1WSfEM1AYbWX3Gwg0CYzbg.png" data-width="693" data-height="476" src="https://cdn-images-1.medium.com/max/800/1*1WSfEM1AYbWX3Gwg0CYzbg.png"></figure><p name="ba0b" id="ba0b" class="graf graf--p graf-after--figure"><strong class="markup--strong markup--p-strong"><em class="markup--em markup--p-em">CTFlearnH {fl4ggyfH E H U H E l4g}<br>CTFlearn{fl4ggyf###}</em></strong></p><p name="800a" id="800a" class="graf graf--p graf-after--p"><strong class="markup--strong markup--p-strong"><em class="markup--em markup--p-em">No, I will not leave him that easily, my friend. You have to try</em></strong></p><blockquote name="5af6" id="5af6" class="graf graf--blockquote graf-after--p">Here is the flag<br>See you soon in other reports….!!</blockquote><blockquote name="532a" id="532a" class="graf graf--blockquote graf-after--blockquote">Abdelwahab_Shandy</blockquote><blockquote name="9787" id="9787" class="graf graf--blockquote graf-after--blockquote graf--trailing">AS_Cyber</blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/b282873ca8e3"><time class="dt-published" datetime="2023-12-17T15:53:09.062Z">December 17, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/ctflearn-im-a-dump-b282873ca8e3" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>