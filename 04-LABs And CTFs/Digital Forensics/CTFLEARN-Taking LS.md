<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>CTFLEARN: Taking LS</title><style>
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
<h1 class="p-name">CTFLEARN: Taking LS</h1>
</header>
<section data-field="subtitle" class="p-summary">
Forensics
</section>
<section data-field="body" class="e-content">
<section name="8fec" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="2a95" id="2a95" class="graf graf--h3 graf--leading graf--title">CTFLEARN: Taking LS</h3><p name="f1d9" id="f1d9" class="graf graf--p graf-after--h3">Forensics</p><figure name="a4e1" id="a4e1" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*iNYIzHzF73rMzALxMpPZyQ.png" data-width="746" data-height="618" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*iNYIzHzF73rMzALxMpPZyQ.png"><figcaption class="imageCaption">Taking LS</figcaption></figure><p name="2cd7" id="2cd7" class="graf graf--p graf-after--figure"><a href="https://ctflearn.com/challenge/103" data-href="https://ctflearn.com/challenge/103" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">https://ctflearn.com/challenge/103</a></p><p name="75bc" id="75bc" class="graf graf--p graf-after--p">Just take the Ls. Check out this zip file and I be the flag will remain hidden. <a href="https://mega.nz/#!mCgBjZgB!_FtmAm8s_mpsHr7KWv8GYUzhbThNn0I8cHMBi4fJQp8" data-href="https://mega.nz/#!mCgBjZgB!_FtmAm8s_mpsHr7KWv8GYUzhbThNn0I8cHMBi4fJQp8" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">https://mega.nz/#!mCgBjZgB!_FtmAm8s_mpsHr7KWv8GYUzhbThNn0I8cHMBi4fJQp8</a></p><p name="1877" id="1877" class="graf graf--p graf-after--p">Don’t forget we always work inside VMs .</p><p name="3be3" id="3be3" class="graf graf--p graf-after--p">So we’ll upload the file there and then :</p><figure name="e4a8" id="e4a8" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*hb2rdm-maJ3LMdybalrb4w.png" data-width="656" data-height="352" src="https://cdn-images-1.medium.com/max/800/1*hb2rdm-maJ3LMdybalrb4w.png"></figure><p name="17ae" id="17ae" class="graf graf--p graf-after--figure">First we have to know the file type using file ,When we found the file with the zip extension, we now have to decompress the file .</p><p name="ee36" id="ee36" class="graf graf--p graf-after--p">The <code class="markup--code markup--p-code"><strong class="markup--strong markup--p-strong">unzip</strong></code> command in Linux is used to extract the contents of a ZIP archive. When you run the command <code class="markup--code markup--p-code">unzip The\ Flag.zip</code>, it attempts to extract the files and directories contained in the &#39;The Flag.zip&#39; archive.</p><p name="be49" id="be49" class="graf graf--p graf-after--p">Here’s a breakdown of the command:</p><ul class="postList"><li name="d3df" id="d3df" class="graf graf--li graf-after--p"><strong class="markup--strong markup--li-strong">unzip</strong>: This is the command-line utility for extracting files from ZIP archives.</li><li name="fc6a" id="fc6a" class="graf graf--li graf-after--li"><strong class="markup--strong markup--li-strong">The\ Flag.zip</strong>: This is the name of the ZIP file you want to extract. The backslash (<code class="markup--code markup--li-code">\</code>) is used to escape the space in the filename.</li></ul><figure name="88a8" id="88a8" class="graf graf--figure graf-after--li"><img class="graf-image" data-image-id="1*ZMcArcRx6fwMNraNW3zb4A.png" data-width="538" data-height="305" src="https://cdn-images-1.medium.com/max/800/1*ZMcArcRx6fwMNraNW3zb4A.png"></figure><p name="b23b" id="b23b" class="graf graf--p graf-after--figure">The <code class="markup--code markup--p-code"><strong class="markup--strong markup--p-strong">ll</strong></code> command is a commonly used shorthand for the <code class="markup--code markup--p-code">ls -l</code> command in Unix-like operating systems, including Linux. The <code class="markup--code markup--p-code">ls</code> command is used to list directory contents, and the <code class="markup--code markup--p-code">-l</code> option is used to provide detailed information about the files and directories in a long format.</p><figure name="e571" id="e571" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*1nAuTeoLhs3EnJcxl3jEiA.png" data-width="479" data-height="88" src="https://cdn-images-1.medium.com/max/800/1*1nAuTeoLhs3EnJcxl3jEiA.png"></figure><p name="8cbf" id="8cbf" class="graf graf--p graf-after--figure">The <code class="markup--code markup--p-code"><strong class="markup--strong markup--p-strong">qpdf --show-xref &#39;The Flag.pdf&#39;</strong></code> command is used with the <code class="markup--code markup--p-code">qpdf</code> tool to display the cross-reference (xref) table of a PDF file named &#39;The Flag.pdf&#39;. The cross-reference table is a critical part of the internal structure of a PDF file, and it helps PDF readers locate and access different parts of the file efficiently.</p><p name="5a58" id="5a58" class="graf graf--p graf-after--p">Let’s break down the components of the command:</p><ul class="postList"><li name="7bb7" id="7bb7" class="graf graf--li graf-after--p"><strong class="markup--strong markup--li-strong">qpdf</strong>: This is the command-line tool that provides various capabilities for transforming and inspecting PDF files.</li><li name="49b6" id="49b6" class="graf graf--li graf-after--li"><strong class="markup--strong markup--li-strong">— show-xref</strong>: This is an option or flag for the <code class="markup--code markup--li-code">qpdf</code> command. It instructs <code class="markup--code markup--li-code">qpdf</code> to display the cross-reference table of the specified PDF file.</li><li name="f8ac" id="f8ac" class="graf graf--li graf--startsWithSingleQuote graf-after--li"><strong class="markup--strong markup--li-strong">‘The Flag.pdf’</strong>: This is the argument that represents the name of the PDF file you want to examine. Make sure to replace it with the actual filename and path if the file is not in the current working directory.</li></ul><figure name="2a59" id="2a59" class="graf graf--figure graf-after--li"><img class="graf-image" data-image-id="1*_WywYiBnfJbMsM_eSGgSeA.png" data-width="487" data-height="228" src="https://cdn-images-1.medium.com/max/800/1*_WywYiBnfJbMsM_eSGgSeA.png"></figure><p name="7e16" id="7e16" class="graf graf--p graf-after--figure">Here, when we moved to .ThePassword/, we found ThePassword.txt, and when we opened it, we found the password for the pdf.</p><figure name="1d12" id="1d12" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*RsxibZ0yXwgcvHmJH82DXg.png" data-width="656" data-height="495" src="https://cdn-images-1.medium.com/max/800/1*RsxibZ0yXwgcvHmJH82DXg.png"></figure><p name="f939" id="f939" class="graf graf--p graf-after--figure">Here we started by going to the PDF file and entering its password, <strong class="markup--strong markup--p-strong">Im The Flag</strong></p><figure name="16ca" id="16ca" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*KmBqjnfMOfBu_fb0qr5TgQ.png" data-width="655" data-height="398" src="https://cdn-images-1.medium.com/max/800/1*KmBqjnfMOfBu_fb0qr5TgQ.png"></figure><blockquote name="4997" id="4997" class="graf graf--blockquote graf-after--figure"><strong class="markup--strong markup--blockquote-strong">Here we have reached the flag, my friend</strong></blockquote><blockquote name="2d5e" id="2d5e" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">See you soon in other reports….!!</strong></blockquote><blockquote name="8ca1" id="8ca1" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">Abdelwahab_Shandy</strong></blockquote><blockquote name="9b3a" id="9b3a" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong">AS_Cyber</strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/20032c4cfec9"><time class="dt-published" datetime="2023-12-17T12:51:07.685Z">December 17, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/ctflearn-taking-ls-20032c4cfec9" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>