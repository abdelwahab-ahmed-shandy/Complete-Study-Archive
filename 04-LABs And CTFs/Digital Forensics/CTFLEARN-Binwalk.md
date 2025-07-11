<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>CTFLEARN:Binwalk</title><style>
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
<h1 class="p-name">CTFLEARN:Binwalk</h1>
</header>
<section data-field="subtitle" class="p-summary">
Forensics
</section>
<section data-field="body" class="e-content">
<section name="c8db" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="2beb" id="2beb" class="graf graf--h3 graf--leading graf--title">CTFLEARN:Binwalk</h3><p name="5dea" id="5dea" class="graf graf--p graf-after--h3"><strong class="markup--strong markup--p-strong">Forensics</strong></p><figure name="413c" id="413c" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*87zdcYf4KH08teaWONMpig.png" data-width="767" data-height="646" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*87zdcYf4KH08teaWONMpig.png"></figure><p name="1eb9" id="1eb9" class="graf graf--p graf-after--figure"><a href="https://ctflearn.com/challenge/108" data-href="https://ctflearn.com/challenge/108" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Challenge — Binwalk — CTFlearn — CTF Practice — CTF Problems — CTF Challenges</a></p><p name="7f66" id="7f66" class="graf graf--p graf-after--p">Here is a file with another file hidden inside it. Can you extract it? <a href="https://mega.nz/#!qbpUTYiK!-deNdQJxsQS8bTSMxeUOtpEclCI-zpK7tbJiKV0tXYY" data-href="https://mega.nz/#!qbpUTYiK!-deNdQJxsQS8bTSMxeUOtpEclCI-zpK7tbJiKV0tXYY" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">https://mega.nz/#!qbpUTYiK!-deNdQJxsQS8bTSMxeUOtpEclCI-zpK7tbJiKV0tXYY</a></p><figure name="5554" id="5554" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*xkxfxJjRw9RIVjK2gvhs7w.png" data-width="708" data-height="243" src="https://cdn-images-1.medium.com/max/800/1*xkxfxJjRw9RIVjK2gvhs7w.png"></figure><p name="0496" id="0496" class="graf graf--p graf-after--figure">I always change the names to something that is closest to what we do, so I changed the name of the file to the name of the task that we are doing now. Now let’s get started.</p><figure name="dec5" id="dec5" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*JBH4QzDYipF1O9k4ty3TfA.png" data-width="710" data-height="171" src="https://cdn-images-1.medium.com/max/800/1*JBH4QzDYipF1O9k4ty3TfA.png"></figure><p name="a245" id="a245" class="graf graf--p graf-after--figure">Here we define the file type .</p><figure name="33c0" id="33c0" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*EoacJrshTsz0ZvscR5PdZA.png" data-width="708" data-height="385" src="https://cdn-images-1.medium.com/max/800/1*EoacJrshTsz0ZvscR5PdZA.png"></figure><p name="9d4b" id="9d4b" class="graf graf--p graf-after--figure">I used exiftool, but didn’t find anything interesting :</p><p name="b97e" id="b97e" class="graf graf--p graf-after--p">It was in the title of the question that the file is hidden. You should extract it, then:</p><figure name="880d" id="880d" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*dN4j8u9FtkBS5pS53P4jKQ.png" data-width="710" data-height="198" src="https://cdn-images-1.medium.com/max/800/1*dN4j8u9FtkBS5pS53P4jKQ.png"></figure><p name="a0df" id="a0df" class="graf graf--p graf-after--figure">The <code class="markup--code markup--p-code"><strong class="markup--strong markup--p-strong">binwalk</strong></code><strong class="markup--strong markup--p-strong"> </strong>command is a tool used for analyzing and extracting embedded files in binary data. In the command you provided:</p><ul class="postList"><li name="2386" id="2386" class="graf graf--li graf-after--p"><strong class="markup--strong markup--li-strong">binwalk</strong>: This is the command-line tool itself.</li><li name="2522" id="2522" class="graf graf--li graf-after--li"><strong class="markup--strong markup--li-strong">— extract</strong>: This option instructs <code class="markup--code markup--li-code">binwalk</code> to attempt to extract any files that it finds.</li><li name="efa3" id="efa3" class="graf graf--li graf-after--li"><strong class="markup--strong markup--li-strong">— dd=”.*”</strong>: This option specifies a regular expression pattern for files to be extracted. In this case, it’s set to “.*”, which essentially matches any file.</li><li name="cf80" id="cf80" class="graf graf--li graf-after--li"><strong class="markup--strong markup--li-strong">Binwalk.jpeg</strong>: This is the name of the file (presumably a JPEG image in this case) that you want to analyze and extract embedded files from.</li></ul><p name="7ec0" id="7ec0" class="graf graf--p graf-after--li">So, when you run this command, <code class="markup--code markup--p-code">binwalk</code> will analyze the &#39;Binwalk.jpeg&#39; file, attempt to find embedded files, and extract them. The <code class="markup--code markup--p-code">--dd</code> option with the regular expression &quot;.*&quot; allows it to extract any files it finds in the binary data.</p><figure name="1f8f" id="1f8f" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*51giBK_g4fMghPtRPUq0tg.png" data-width="882" data-height="599" src="https://cdn-images-1.medium.com/max/800/1*51giBK_g4fMghPtRPUq0tg.png"></figure><p name="bafc" id="bafc" class="graf graf--p graf-after--figure">When I used strings I didn’t find anything interesting :</p><figure name="f1b9" id="f1b9" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*c9Jh00NDWTNK5yftTsROSQ.png" data-width="884" data-height="590" src="https://cdn-images-1.medium.com/max/800/1*c9Jh00NDWTNK5yftTsROSQ.png"></figure><p name="4300" id="4300" class="graf graf--p graf-after--figure">The <code class="markup--code markup--p-code"><strong class="markup--strong markup--p-strong">eog</strong></code> command is used to launch the Eye of GNOME (EOG) image viewer on Linux systems. The command you provided, <code class="markup--code markup--p-code">eog 25795</code>, is likely an attempt to open an image file with the EOG viewer.</p><p name="cf47" id="cf47" class="graf graf--p graf-after--p">Here’s a breakdown of the components:</p><ul class="postList"><li name="3392" id="3392" class="graf graf--li graf-after--p"><strong class="markup--strong markup--li-strong">eog</strong>: This is the command to start the Eye of GNOME image viewer.</li><li name="765f" id="765f" class="graf graf--li graf-after--li"><strong class="markup--strong markup--li-strong">25795</strong>: This is likely the name of the image file you want to open with EOG.</li></ul><p name="2ece" id="2ece" class="graf graf--p graf-after--li">So, when you run <code class="markup--code markup--p-code">eog 25795</code>, it attempts to open and display the image file named &quot;25795&quot; using the Eye of GNOME viewer. If the file exists in the current working directory, EOG will open and display the image. If the file is in a different directory, you may need to provide the full path to the image file.</p><blockquote name="480b" id="480b" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">Here is the flag<br>See you soon in other reports….!!</em></strong></blockquote><blockquote name="c882" id="c882" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">Abdelwahab_Shandy</em></strong></blockquote><blockquote name="3a9a" id="3a9a" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">AS_Cyber</em></strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/a5d7ef0f37ac"><time class="dt-published" datetime="2023-12-17T13:56:12.420Z">December 17, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/ctflearn-binwalk-a5d7ef0f37ac" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>