<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>CTFLEARN:Simple Steganography</title><style>
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
<h1 class="p-name">CTFLEARN:Simple Steganography</h1>
</header>
<section data-field="subtitle" class="p-summary">
Forensics
</section>
<section data-field="body" class="e-content">
<section name="7c1a" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="f5f4" id="f5f4" class="graf graf--h3 graf--leading graf--title">CTFLEARN:Simple Steganography</h3><p name="27f6" id="27f6" class="graf graf--p graf-after--h3"><strong class="markup--strong markup--p-strong">Forensics</strong></p><figure name="ac7a" id="ac7a" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*8izPPrPySInO8tiaEugWcg.png" data-width="767" data-height="630" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*8izPPrPySInO8tiaEugWcg.png"></figure><p name="ac94" id="ac94" class="graf graf--p graf-after--figure"><a href="https://ctflearn.com/challenge/894" data-href="https://ctflearn.com/challenge/894" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Challenge — Simple Steganography — CTFlearn — CTF Practice — CTF Problems — CTF Challenges</a></p><p name="c85c" id="c85c" class="graf graf--p graf-after--p">Think the flag is somewhere in there. Would you help me find it? hint-” Steghide Might be Helpfull”</p><p name="4250" id="4250" class="graf graf--p graf-after--p">Don’t forget we always work inside VMs .</p><p name="f4e9" id="f4e9" class="graf graf--p graf-after--p">So we’ll upload the file there and then :</p><p name="7b2f" id="7b2f" class="graf graf--p graf-after--p">We took the download link and used <strong class="markup--strong markup--p-strong">wget </strong>to download the :</p><figure name="3c9a" id="3c9a" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*2eO9q9FoL3L0AXy8x3ze0A.png" data-width="683" data-height="337" src="https://cdn-images-1.medium.com/max/800/1*2eO9q9FoL3L0AXy8x3ze0A.png"></figure><p name="ff20" id="ff20" class="graf graf--p graf-after--figure">I always change the names to something that is closest to what we do, so I changed the name of the file to the name of the task that we are doing now , Now let’s get started :</p><figure name="6948" id="6948" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*SQ8fHiQwjbqRQ62JPljAvg.png" data-width="682" data-height="246" src="https://cdn-images-1.medium.com/max/800/1*SQ8fHiQwjbqRQ62JPljAvg.png"></figure><p name="0bba" id="0bba" class="graf graf--p graf-after--figure">Here we define the <strong class="markup--strong markup--p-strong">file </strong>type , There are a lot of interesting things :</p><figure name="46e4" id="46e4" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*ZlLUE3_9VW8s6hdqNEZoPA.png" data-width="684" data-height="97" src="https://cdn-images-1.medium.com/max/800/1*ZlLUE3_9VW8s6hdqNEZoPA.png"></figure><p name="be87" id="be87" class="graf graf--p graf-after--figure">I decided to use exif and exiftool, but nothing new :</p><figure name="30f9" id="30f9" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*25y5XQ7h2_EwhngxuSZxMQ.png" data-width="684" data-height="536" src="https://cdn-images-1.medium.com/max/800/1*25y5XQ7h2_EwhngxuSZxMQ.png"></figure><p name="0323" id="0323" class="graf graf--p graf-after--figure">It seems like strings didn’t work this time :</p><figure name="3613" id="3613" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*m6C56W87T-l-4lNqtAgLSQ.png" data-width="684" data-height="518" src="https://cdn-images-1.medium.com/max/800/1*m6C56W87T-l-4lNqtAgLSQ.png"></figure><p name="5e62" id="5e62" class="graf graf--p graf-after--figure">The appearance of the word (myadmin) caught my attention in every way.</p><figure name="7bef" id="7bef" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*hWWEQhpo6-R64VuzQgQYew.png" data-width="683" data-height="156" src="https://cdn-images-1.medium.com/max/800/1*hWWEQhpo6-R64VuzQgQYew.png"></figure><p name="47b6" id="47b6" class="graf graf--p graf-after--figure">I went back and found keywords, but why?</p><figure name="0b5e" id="0b5e" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*HlkZaKHGkW6uu4cEGm6--A.png" data-width="317" data-height="81" src="https://cdn-images-1.medium.com/max/800/1*HlkZaKHGkW6uu4cEGm6--A.png"></figure><p name="0e00" id="0e00" class="graf graf--p graf-after--figure">Binwalk didn’t work either :</p><figure name="49b0" id="49b0" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*M_wuFR8Kc-Yp49kg111PNg.png" data-width="681" data-height="504" src="https://cdn-images-1.medium.com/max/800/1*M_wuFR8Kc-Yp49kg111PNg.png"></figure><p name="1ae6" id="1ae6" class="graf graf--p graf-after--figure">I used foremost :</p><figure name="cc74" id="cc74" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*VdHqmRUQX_uKETsTE9SHxQ.png" data-width="685" data-height="393" src="https://cdn-images-1.medium.com/max/800/1*VdHqmRUQX_uKETsTE9SHxQ.png"></figure><blockquote name="723f" id="723f" class="graf graf--blockquote graf-after--figure"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">Let’s break down the options you’ve provided:</em></strong></blockquote><blockquote name="7515" id="7515" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">-v</strong>: This stands for verbose mode, which means the command will provide more detailed output about its operations.</blockquote><blockquote name="9a93" id="9a93" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">-q</strong>: This stands for quiet mode, which typically suppresses normal output, and only error messages or important information are displayed.</blockquote><blockquote name="3c6a" id="3c6a" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">i Minionsl.jpeg</strong>: This specifies the input file or device from which foremost should recover data. In this case, it’s looking for data in the file named “Minionsl.jpeg.”</blockquote><figure name="1cea" id="1cea" class="graf graf--figure graf-after--blockquote"><img class="graf-image" data-image-id="1*LAUBzxlG0pA_gZ1fW9FMHA.png" data-width="686" data-height="535" src="https://cdn-images-1.medium.com/max/800/1*LAUBzxlG0pA_gZ1fW9FMHA.png"></figure><p name="9219" id="9219" class="graf graf--p graf-after--figure">It seems that the matter is related to the audit file. Inside the image, after all this research, it appears that the private key to open this file is (myadmin).</p><p name="06e7" id="06e7" class="graf graf--p graf-after--p">Well we have to use Google, it has been discontinued .</p><blockquote name="8a1d" id="8a1d" class="graf graf--blockquote graf-after--p">After a lot of searching I found a tool called steghide, I installed it and then…</blockquote><figure name="f07c" id="f07c" class="graf graf--figure graf-after--blockquote"><img class="graf-image" data-image-id="1*z7k-vTTx6Lbi7zs4R-SH5Q.png" data-width="682" data-height="58" src="https://cdn-images-1.medium.com/max/800/1*z7k-vTTx6Lbi7zs4R-SH5Q.png"></figure><blockquote name="551f" id="551f" class="graf graf--blockquote graf-after--figure">We used help :</blockquote><figure name="bdf9" id="bdf9" class="graf graf--figure graf-after--blockquote"><img class="graf-image" data-image-id="1*smFjVc_MgBahgoBV7DlkDA.png" data-width="684" data-height="65" src="https://cdn-images-1.medium.com/max/800/1*smFjVc_MgBahgoBV7DlkDA.png"></figure><blockquote name="ed66" id="ed66" class="graf graf--blockquote graf-after--figure">Let’s break down the options you’ve provided:</blockquote><blockquote name="3636" id="3636" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">steghide — extract -sf Minionsl.jpeg -p myadmin<br> — extract</strong>: This option specifies that you want to extract (uncover) hidden data from the specified file.</blockquote><blockquote name="5ed9" id="5ed9" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">-sf Minionsl.jpeg</strong>: This option specifies the source file from which you want to extract the hidden data. In this case, it’s “Minionsl.jpeg.”</blockquote><blockquote name="8b50" id="8b50" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">-p myadmin</strong>: This option is used to provide the passphrase or password that was used during the embedding process. The passphrase is necessary to successfully extract the hidden data.</blockquote><blockquote name="b0a1" id="b0a1" class="graf graf--blockquote graf-after--blockquote">So, the command is instructing steghide to extract hidden data from the “Minionsl.jpeg” file using the passphrase “myadmin.” Keep in mind that the success of the extraction depends on using the correct passphrase that was used during the embedding process.</blockquote><figure name="fa97" id="fa97" class="graf graf--figure graf-after--blockquote"><img class="graf-image" data-image-id="1*O2DXldj7rk_iJ2sidqXeuQ.png" data-width="606" data-height="279" src="https://cdn-images-1.medium.com/max/800/1*O2DXldj7rk_iJ2sidqXeuQ.png"></figure><p name="100d" id="100d" class="graf graf--p graf-after--figure">Here I used <a href="https://cyberchef.org/" data-href="https://cyberchef.org/" class="markup--anchor markup--p-anchor" rel="nofollow noopener" target="_blank">https://cyberchef.org/</a> , I didn’t know what to use so I used migic:</p><figure name="b650" id="b650" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*OrJVj4kHr77l1z1C8wJ17A.png" data-width="1102" data-height="452" src="https://cdn-images-1.medium.com/max/800/1*OrJVj4kHr77l1z1C8wJ17A.png"></figure><p name="fff3" id="fff3" class="graf graf--p graf-after--figure">Well it looks like Base64 :</p><figure name="73ff" id="73ff" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*Owr-1JQNRi15hV7UQGJ3rg.png" data-width="1060" data-height="343" src="https://cdn-images-1.medium.com/max/800/1*Owr-1JQNRi15hV7UQGJ3rg.png"></figure><p name="93e2" id="93e2" class="graf graf--p graf-after--figure">To make it more clear, I used the command :</p><figure name="1d93" id="1d93" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*7tNGkGTXyIxU3oeUXZAg7w.png" data-width="683" data-height="136" src="https://cdn-images-1.medium.com/max/800/1*7tNGkGTXyIxU3oeUXZAg7w.png"></figure><blockquote name="88f8" id="88f8" class="graf graf--blockquote graf-after--figure"><strong class="markup--strong markup--blockquote-strong">Here is the flag<br>See you soon in other reports….!!</strong></blockquote><blockquote name="0b34" id="0b34" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">Abdelwahab_Shandy</strong></blockquote><blockquote name="1e9d" id="1e9d" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong">AS_Cyber</strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/9e23f5d18da4"><time class="dt-published" datetime="2023-12-21T16:17:08.665Z">December 21, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/ctflearn-simple-steganography-9e23f5d18da4" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>