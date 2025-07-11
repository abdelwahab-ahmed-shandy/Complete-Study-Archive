<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>CTFLEARN:Minions</title><style>
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
<h1 class="p-name">CTFLEARN:Minions</h1>
</header>
<section data-field="subtitle" class="p-summary">
Forensics
</section>
<section data-field="body" class="e-content">
<section name="a381" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="f1e1" id="f1e1" class="graf graf--h3 graf--leading graf--title">CTFLEARN:Minions</h3><p name="3988" id="3988" class="graf graf--p graf-after--h3"><strong class="markup--strong markup--p-strong">Forensics</strong></p><figure name="f564" id="f564" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*yUoNTYZVLqNBmFgu0VFaWA.png" data-width="794" data-height="604" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*yUoNTYZVLqNBmFgu0VFaWA.png"></figure><p name="a581" id="a581" class="graf graf--p graf-after--figure"><a href="https://ctflearn.com/challenge/955" data-href="https://ctflearn.com/challenge/955" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Challenge — Minions — CTFlearn — CTF Practice — CTF Problems — CTF Challenges</a></p><p name="9a34" id="9a34" class="graf graf--p graf-after--p">Hey! Minions have stolen my flag, encoded it few times in one cipher, and then hidden it somewhere there: <a href="https://mega.nz/file/1UBViYgD#kjKISs9pUB4E-1d79166FeX3TiY5VQcHJ_GrcMbaLhg" data-href="https://mega.nz/file/1UBViYgD#kjKISs9pUB4E-1d79166FeX3TiY5VQcHJ_GrcMbaLhg" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">https://mega.nz/file/1UBViYgD#kjKISs9pUB4E-1d79166FeX3TiY5VQcHJ_GrcMbaLhg</a> Can you help me? TIP: Decode the flag until you got a sentence.</p><p name="f882" id="f882" class="graf graf--p graf-after--p">Don’t forget we always work inside VMs .</p><p name="0976" id="0976" class="graf graf--p graf-after--p">So we’ll upload the file there and then :</p><figure name="ddb9" id="ddb9" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*V3P74sJxl-JgbtnucmHfDw.png" data-width="535" data-height="109" src="https://cdn-images-1.medium.com/max/800/1*V3P74sJxl-JgbtnucmHfDw.png"></figure><p name="d2d0" id="d2d0" class="graf graf--p graf-after--figure">Here we define the <strong class="markup--strong markup--p-strong">file </strong>type , There are a lot of interesting things :</p><figure name="89d2" id="89d2" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*5qVoDon1HChkhMLnZEcxiw.png" data-width="529" data-height="62" src="https://cdn-images-1.medium.com/max/800/1*5qVoDon1HChkhMLnZEcxiw.png"></figure><p name="e3a7" id="e3a7" class="graf graf--p graf-after--figure">I decided to use exif and exiftool, but no positive result :</p><p name="486c" id="486c" class="graf graf--p graf-after--p">Then we used binwalk :</p><figure name="d91b" id="d91b" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*vycGuOZbP6Wx5wOhy9-OnA.png" data-width="683" data-height="156" src="https://cdn-images-1.medium.com/max/800/1*vycGuOZbP6Wx5wOhy9-OnA.png"></figure><p name="4ca5" id="4ca5" class="graf graf--p graf-after--figure">We accessed the extracted file, and then determined the type of this compressed file:</p><figure name="f4c0" id="f4c0" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*x1AMbFy8SM_VXuU48LJilA.png" data-width="683" data-height="345" src="https://cdn-images-1.medium.com/max/800/1*x1AMbFy8SM_VXuU48LJilA.png"></figure><p name="05d0" id="05d0" class="graf graf--p graf-after--figure">It seems that the file (..txt) is related to something :</p><figure name="22ea" id="22ea" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*pQpNn0ZHSuN_0HygulREaQ.png" data-width="684" data-height="469" src="https://cdn-images-1.medium.com/max/800/1*pQpNn0ZHSuN_0HygulREaQ.png"></figure><p name="c592" id="c592" class="graf graf--p graf-after--figure">We read the file :</p><figure name="5290" id="5290" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*vBsr1y_G3TVJ5kFXZIuSrw.png" data-width="684" data-height="84" src="https://cdn-images-1.medium.com/max/800/1*vBsr1y_G3TVJ5kFXZIuSrw.png"></figure><p name="1ade" id="1ade" class="graf graf--p graf-after--figure">There appears to be a file , I downloaded the file :</p><figure name="b1cd" id="b1cd" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*H76T57tqhk3OrX-3x89PIA.png" data-width="683" data-height="143" src="https://cdn-images-1.medium.com/max/800/1*H76T57tqhk3OrX-3x89PIA.png"></figure><p name="0dbf" id="0dbf" class="graf graf--p graf-after--figure">Here we define the <strong class="markup--strong markup--p-strong">file </strong>type , There are a lot of interesting things :</p><p name="bbe7" id="bbe7" class="graf graf--p graf-after--p">I decided to use exif and exiftool, but no positive result :</p><p name="a219" id="a219" class="graf graf--p graf-after--p">Then we used binwalk :</p><figure name="7d2b" id="7d2b" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*c8BjSsjLyeVbMaLbYUII6g.png" data-width="683" data-height="303" src="https://cdn-images-1.medium.com/max/800/1*c8BjSsjLyeVbMaLbYUII6g.png"></figure><p name="e834" id="e834" class="graf graf--p graf-after--figure">It seems I reached the goal :</p><figure name="ea53" id="ea53" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*oo23W44nHQERHkLs9yP9Lw.png" data-width="683" data-height="208" src="https://cdn-images-1.medium.com/max/800/1*oo23W44nHQERHkLs9yP9Lw.png"></figure><p name="e81d" id="e81d" class="graf graf--p graf-after--figure">I decided to use file and exiftool, but nothing seemed to really matter :</p><figure name="75d0" id="75d0" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*nqU38dTWSpvnUpuzyK46VQ.png" data-width="682" data-height="488" src="https://cdn-images-1.medium.com/max/800/1*nqU38dTWSpvnUpuzyK46VQ.png"></figure><p name="ad8b" id="ad8b" class="graf graf--p graf-after--figure">I used strings :</p><figure name="8412" id="8412" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*NfET3bTdirRf3PjoMAEJwg.png" data-width="525" data-height="497" src="https://cdn-images-1.medium.com/max/800/1*NfET3bTdirRf3PjoMAEJwg.png"></figure><p name="e3eb" id="e3eb" class="graf graf--p graf-after--figure">I used my friend <a href="https://cyberchef.org/" data-href="https://cyberchef.org/" class="markup--anchor markup--p-anchor" rel="nofollow noopener" target="_blank">https://cyberchef.org/</a> :</p><p name="b3df" id="b3df" class="graf graf--p graf-after--p">And also do not forget that note (TIP: Decode the flag until you got a sentence.)</p><p name="4e3d" id="4e3d" class="graf graf--p graf-after--p">And Base64 :</p><blockquote name="0e78" id="0e78" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">CTF{VmtaU1IxUXhUbFZSYXpsV1RWUnNRMVpYZEZkYWJFWTJVVmhrVlZGVU1Eaz0=)</em></strong></blockquote><blockquote name="9a7d" id="9a7d" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">VmtaU1IxUXhUbFZSYXpsV1RWUnNRMVpYZEZkYWJFWTJVVmhrVlZGVU1Eaz0</em></strong></blockquote><blockquote name="931f" id="931f" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">VkZSR1QxTlVRazlWTVRsQ1ZXdFdabEY2UVhkVVFUMDk=</em></strong></blockquote><blockquote name="72bb" id="72bb" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">VFRGT1NUQk9VMTlCVWtWZlF6QXdUQT09</em></strong></blockquote><blockquote name="bde4" id="bde4" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">TTFOSTBOU19BUkVfQzAwTA==</em></strong></blockquote><blockquote name="e006" id="e006" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">M1NI0NS_ARE_C00L</em></strong></blockquote><blockquote name="99f9" id="99f9" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">CTF{VmtaU1IxUXhUbFZSYXpsV1RWUnNRMVpYZEZkYWJFWTJVVmhrVlZGVU1Eaz0=)</em></strong></blockquote><blockquote name="d576" id="d576" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">CTF{M1NI0NS_ARE_C00L)</em></strong></blockquote><p name="7b76" id="7b76" class="graf graf--p graf-after--blockquote"><em class="markup--em markup--p-em">See you soon in other reports….!!</em></p><p name="317c" id="317c" class="graf graf--p graf-after--p"><em class="markup--em markup--p-em">Abdelwahab_Shandy</em></p><p name="ccfc" id="ccfc" class="graf graf--p graf-after--p graf--trailing"><em class="markup--em markup--p-em">AS_Cyber</em></p></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/4f6940406fd7"><time class="dt-published" datetime="2023-12-21T18:13:54.262Z">December 21, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/ctflearn-minions-4f6940406fd7" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>