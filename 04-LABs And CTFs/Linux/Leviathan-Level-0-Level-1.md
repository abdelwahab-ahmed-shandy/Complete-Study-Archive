<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>Leviathan Level 0 → Level 1</title><style>
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
<h1 class="p-name">Leviathan Level 0 → Level 1</h1>
</header>
<section data-field="subtitle" class="p-summary">
OverTheWire
</section>
<section data-field="body" class="e-content">
<section name="e53a" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="95d1" id="95d1" class="graf graf--h3 graf--leading graf--title">Leviathan Level 0 → Level 1</h3><p name="7cb6" id="7cb6" class="graf graf--p graf-after--h3">OverTheWire</p><figure name="ff1c" id="ff1c" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*FOdhsAAxh1Wq7bT6UdFN5A.png" data-width="1063" data-height="565" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*FOdhsAAxh1Wq7bT6UdFN5A.png"></figure><p name="fa45" id="fa45" class="graf graf--p graf-after--figure">There is no information for this level, intentionally.</p><blockquote name="2350" id="2350" class="graf graf--blockquote graf-after--p"><em class="markup--em markup--blockquote-em">ssh -p 2223 leviathan1@leviathan.labs.overthewire.org<br>Password: </em>PPIfmI1qsA</blockquote><figure name="7308" id="7308" class="graf graf--figure graf-after--blockquote"><img class="graf-image" data-image-id="1*snsxqbSeqr4ck5M2uXowKw.png" data-width="553" data-height="221" src="https://cdn-images-1.medium.com/max/800/1*snsxqbSeqr4ck5M2uXowKw.png"></figure><p name="c546" id="c546" class="graf graf--p graf-after--figure">When you look at the permissions on this file, you will find that we are now in group :</p><figure name="5e1e" id="5e1e" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*IQ44FJ7SJ4O3XTEDTCmrWQ.png" data-width="513" data-height="297" src="https://cdn-images-1.medium.com/max/800/1*IQ44FJ7SJ4O3XTEDTCmrWQ.png"></figure><p name="521e" id="521e" class="graf graf--p graf-after--figure">The command <code class="markup--code markup--p-code"><strong class="markup--strong markup--p-strong">ltrace ./check</strong></code> is used to dynamically trace the library calls made by the program <code class="markup--code markup--p-code"><strong class="markup--strong markup--p-strong">./check</strong></code>. It provides information about each library function call, including:</p><ul class="postList"><li name="49b0" id="49b0" class="graf graf--li graf-after--p">Function name: The name of the library function being called.</li><li name="5d03" id="5d03" class="graf graf--li graf-after--li">Arguments: The arguments that are being passed to the function.</li><li name="2337" id="2337" class="graf graf--li graf-after--li">Return value: The return value of the function.</li><li name="e44a" id="e44a" class="graf graf--li graf-after--li">Error status: Any error status that was returned by the function.</li><li name="8434" id="8434" class="graf graf--li graf-after--li">Time: The time it took for the function to execute.</li></ul><p name="9310" id="9310" class="graf graf--p graf-after--li">Ltrace can be a useful tool for debugging programs, as it can help you to identify which library functions are being called and what arguments are being passed to them. It can also be used to measure the performance of programs, as it can show you how long each library function is taking to execute.</p><p name="9ea1" id="9ea1" class="graf graf--p graf-after--p">Here are some additional details about ltrace:</p><ul class="postList"><li name="0b6a" id="0b6a" class="graf graf--li graf-after--p">It only traces library calls, not system calls. For tracing system calls, you can use the <code class="markup--code markup--li-code">strace</code> command.</li><li name="f43a" id="f43a" class="graf graf--li graf-after--li">It can be used to trace both statically and dynamically linked libraries.</li><li name="c1f9" id="c1f9" class="graf graf--li graf-after--li">It can be used to trace specific libraries or functions.</li><li name="4219" id="4219" class="graf graf--li graf-after--li">It can be used to filter the output based on various criteria.</li></ul><p name="a7ff" id="a7ff" class="graf graf--p graf-after--li">Here are some examples of how to use ltrace:</p><ul class="postList"><li name="63c8" id="63c8" class="graf graf--li graf-after--p">To trace all library calls made by <code class="markup--code markup--li-code">./check</code>:</li><li name="8ed9" id="8ed9" class="graf graf--li graf-after--li">To trace only library calls made to the <code class="markup--code markup--li-code">printf</code> function:</li></ul><p name="b3e1" id="b3e1" class="graf graf--p graf-after--li">So it seems that he provided the password for us to use this file :</p><figure name="26c6" id="26c6" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*6l5dSKXVgNIPUY6TEWhULw.png" data-width="322" data-height="138" src="https://cdn-images-1.medium.com/max/800/1*6l5dSKXVgNIPUY6TEWhULw.png"></figure><p name="2aca" id="2aca" class="graf graf--p graf-after--figure">Here, after searching the files, I found the password here :</p><ul class="postList"><li name="dc5e" id="dc5e" class="graf graf--li graf-after--p"><code class="markup--code markup--li-code"><strong class="markup--strong markup--li-strong">cat</strong></code> is a command-line utility used to display the contents of a file.</li><li name="5ee8" id="5ee8" class="graf graf--li graf-after--li"><code class="markup--code markup--li-code"><strong class="markup--strong markup--li-strong">/etc/leviathan_pass/leviathan2</strong></code> is a specific file path.</li><li name="1c27" id="1c27" class="graf graf--li graf-after--li">Executing this command would display the contents of the file <code class="markup--code markup--li-code"><strong class="markup--strong markup--li-strong">/etc/leviathan_pass/leviathan2</strong></code> on the terminal.</li></ul><p name="ab67" id="ab67" class="graf graf--p graf-after--li">pass : mEh5PNl10e</p><blockquote name="1140" id="1140" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong"><em class="markup--em markup--blockquote-em">See you soon in other reports….!!</em></strong></blockquote><blockquote name="824b" id="824b" class="graf graf--blockquote graf-after--blockquote"><em class="markup--em markup--blockquote-em">Abdelwahab_Shandy</em></blockquote><blockquote name="6d81" id="6d81" class="graf graf--blockquote graf-after--blockquote graf--trailing"><em class="markup--em markup--blockquote-em">AS_Cyber</em></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/45706999e5fd"><time class="dt-published" datetime="2023-12-07T00:49:21.830Z">December 7, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/leviathan-level-0-level-1-45706999e5fd" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>