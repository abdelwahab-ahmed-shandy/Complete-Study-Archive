<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>CTFLEARN: Git Is Good</title><style>
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
<h1 class="p-name">CTFLEARN: Git Is Good</h1>
</header>
<section data-field="subtitle" class="p-summary">
Forensics
</section>
<section data-field="body" class="e-content">
<section name="2eef" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="a6b6" id="a6b6" class="graf graf--h3 graf--leading graf--title">CTFLEARN: Git Is Good</h3><p name="c709" id="c709" class="graf graf--p graf-after--h3"><strong class="markup--strong markup--p-strong">Forensics</strong></p><figure name="97ec" id="97ec" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*uQxau3Ns2Qhj8WZwRtMbTg.png" data-width="752" data-height="628" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*uQxau3Ns2Qhj8WZwRtMbTg.png"></figure><p name="887c" id="887c" class="graf graf--p graf-after--figure"><a href="https://ctflearn.com/challenge/104" data-href="https://ctflearn.com/challenge/104" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Challenge — Git Is Good — CTFlearn — CTF Practice — CTF Problems — CTF Challenges</a></p><p name="2541" id="2541" class="graf graf--p graf-after--p">The flag used to be there. But then I redacted it. Good Luck. <a href="https://mega.nz/#!3CwDFZpJ!Jjr55hfJQJ5-jspnyrnVtqBkMHGJrd6Nn_QqM7iXEuc" data-href="https://mega.nz/#!3CwDFZpJ!Jjr55hfJQJ5-jspnyrnVtqBkMHGJrd6Nn_QqM7iXEuc" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">https://mega.nz/#!3CwDFZpJ!Jjr55hfJQJ5-jspnyrnVtqBkMHGJrd6Nn_QqM7iXEuc</a></p><p name="1415" id="1415" class="graf graf--p graf-after--p">Don’t forget we always work inside VMs .</p><p name="5571" id="5571" class="graf graf--p graf-after--p">So we’ll upload the file there and then :</p><figure name="6c94" id="6c94" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*kRZsRdIGNDsPQEitSXXEfg.png" data-width="674" data-height="502" src="https://cdn-images-1.medium.com/max/800/1*kRZsRdIGNDsPQEitSXXEfg.png"></figure><p name="a563" id="a563" class="graf graf--p graf-after--figure">Here we have decompressed the file, after verifying its type :</p><figure name="b101" id="b101" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*sVxqk_M1o3dAzUpPPyB9vQ.png" data-width="469" data-height="156" src="https://cdn-images-1.medium.com/max/800/1*sVxqk_M1o3dAzUpPPyB9vQ.png"></figure><p name="e9cb" id="e9cb" class="graf graf--p graf-after--figure">Here we navigated to the compressed file using cd, then read the flag.txt file using cat .</p><p name="3f05" id="3f05" class="graf graf--p graf-after--p">I didn’t think it would be that easy, so I continued my research :</p><figure name="6ebf" id="6ebf" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*UE5aa0uSIEu0n1Dcoq17oQ.png" data-width="549" data-height="415" src="https://cdn-images-1.medium.com/max/800/1*UE5aa0uSIEu0n1Dcoq17oQ.png"></figure><p name="e6c6" id="e6c6" class="graf graf--p graf-after--figure">The command <code class="markup--code markup--p-code u-paddingRight0 u-marginRight0"><strong class="markup--strong markup--p-strong">grep -r &#39;flag&#39;</strong> <strong class="markup--strong markup--p-strong">/home/sansforensics/CTFLERARN/gitIsGood/.git/</strong></code> is searching for the string &#39;flag&#39; recursively in all files within the specified directory <code class="markup--code markup--p-code"><strong class="markup--strong markup--p-strong">/home/sansforensics/CTFLERARN/gitIsGood/.git/</strong></code> and its subdirectories. Here&#39;s a breakdown of the components:</p><ul class="postList"><li name="0838" id="0838" class="graf graf--li graf-after--p"><strong class="markup--strong markup--li-strong">grep</strong>: This is the command-line utility used for searching patterns in text.</li><li name="5dab" id="5dab" class="graf graf--li graf-after--li"><strong class="markup--strong markup--li-strong">-r</strong>: This option stands for “recursive” and is used to search for the specified pattern in all files within the specified directory and its subdirectories.</li><li name="30bd" id="30bd" class="graf graf--li graf--startsWithSingleQuote graf-after--li"><strong class="markup--strong markup--li-strong">‘flag’</strong>: This is the string or pattern that <code class="markup--code markup--li-code">grep</code> is searching for in the files.</li><li name="ae05" id="ae05" class="graf graf--li graf-after--li"><strong class="markup--strong markup--li-strong">/home/sansforensics/CTFLERARN/gitIsGood/.git/</strong>: This is the path to the directory where the search is being performed. In this case, it’s the <code class="markup--code markup--li-code">.git</code> directory within the <code class="markup--code markup--li-code">gitIsGood</code> project.</li></ul><figure name="f25a" id="f25a" class="graf graf--figure graf-after--li"><img class="graf-image" data-image-id="1*P8Ts0NrQ63LtRZIZ-QsV9A.png" data-width="684" data-height="333" src="https://cdn-images-1.medium.com/max/800/1*P8Ts0NrQ63LtRZIZ-QsV9A.png"></figure><p name="f9cf" id="f9cf" class="graf graf--p graf-after--figure">The <code class="markup--code markup--p-code"><strong class="markup--strong markup--p-strong">git show HEAD</strong></code> command in Git is used to display the detailed information about the latest commit in the current branch. Here&#39;s a breakdown of the components:</p><ul class="postList"><li name="502c" id="502c" class="graf graf--li graf-after--p"><strong class="markup--strong markup--li-strong">git</strong>: This is the Git version control system.</li><li name="4b18" id="4b18" class="graf graf--li graf-after--li"><strong class="markup--strong markup--li-strong">show</strong>: This is the command used to show various types of objects in Git, such as commits, tags, or trees.</li><li name="e9f8" id="e9f8" class="graf graf--li graf-after--li"><strong class="markup--strong markup--li-strong">HEAD</strong>: This is a special reference that points to the latest commit on the current branch. It represents the tip of the current branch.</li></ul><p name="e645" id="e645" class="graf graf--p graf-after--li">When you run <code class="markup--code markup--p-code">git show HEAD</code>, Git will display information about the latest commit on the current branch, including details such as the commit message, author, date, and the changes made in that commit.</p><figure name="ee77" id="ee77" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*vI_NcE0dQcbT_onxc9sADg.png" data-width="653" data-height="323" src="https://cdn-images-1.medium.com/max/800/1*vI_NcE0dQcbT_onxc9sADg.png"></figure><p name="be49" id="be49" class="graf graf--p graf-after--figure">you see information about the latest commit ,author, date, commit message, and a unified diff showing the changes made in the commit. The actual output may vary based on the content of your commit .</p><blockquote name="cb18" id="cb18" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">Here is the flag<br>See you soon in other reports….!!</em></strong></blockquote><blockquote name="6811" id="6811" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">Abdelwahab_Shandy</em></strong></blockquote><blockquote name="03f6" id="03f6" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">AS_Cyber</em></strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/7f2a57783f69"><time class="dt-published" datetime="2023-12-17T15:08:19.728Z">December 17, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/ctflearn-git-is-good-7f2a57783f69" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>