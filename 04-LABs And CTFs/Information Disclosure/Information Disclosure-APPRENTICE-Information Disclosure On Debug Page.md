<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>Information Disclosure : APPRENTICE : Information disclosure on debug page</title><style>
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
<h1 class="p-name">Information Disclosure : APPRENTICE : Information disclosure on debug page</h1>
</header>
<section data-field="subtitle" class="p-summary">
Web Security Academy &gt;&gt; Information disclosure &gt;&gt;Exploiting &gt;&gt;Lab
</section>
<section data-field="body" class="e-content">
<section name="6efe" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="fba5" id="fba5" class="graf graf--h3 graf--leading graf--title">Information Disclosure : APPRENTICE : <a href="https://portswigger.net/web-security/information-disclosure" data-href="https://portswigger.net/web-security/information-disclosure" class="markup--anchor markup--h3-anchor" rel="noopener" target="_blank">Information disclosure</a> on debug page</h3><ul class="postList"><li name="2bee" id="2bee" class="graf graf--li graf-after--h3"><a href="https://portswigger.net/web-security" data-href="https://portswigger.net/web-security" class="markup--anchor markup--li-anchor" rel="noopener" target="_blank">Web Security Academy</a> &gt;&gt; <a href="https://portswigger.net/web-security/information-disclosure" data-href="https://portswigger.net/web-security/information-disclosure" class="markup--anchor markup--li-anchor" rel="noopener" target="_blank">Information disclosure</a> &gt;&gt;<a href="https://portswigger.net/web-security/information-disclosure/exploiting" data-href="https://portswigger.net/web-security/information-disclosure/exploiting" class="markup--anchor markup--li-anchor" rel="noopener" target="_blank">Exploiting</a> &gt;&gt;<a href="https://portswigger.net/web-security/information-disclosure/exploiting/lab-infoleak-on-debug-page" data-href="https://portswigger.net/web-security/information-disclosure/exploiting/lab-infoleak-on-debug-page" class="markup--anchor markup--li-anchor" rel="noopener" target="_blank">Lab</a></li></ul><p name="8391" id="8391" class="graf graf--p graf-after--li">This lab contains a debug page that discloses sensitive information about the application. To solve the lab, obtain and submit the <code class="markup--code markup--p-code">SECRET_KEY</code> environment variable.</p><figure name="cffc" id="cffc" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*WeYusjLzl-2ItwW6ouymCA.png" data-width="1224" data-height="490" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*WeYusjLzl-2ItwW6ouymCA.png"></figure><p name="860c" id="860c" class="graf graf--p graf-after--figure">So it seems that we have to create a debug page through which we reveal sensitive information about the application …………</p><p name="df47" id="df47" class="graf graf--p graf-after--p">We can first search in /robots.txt :</p><p name="51ab" id="51ab" class="graf graf--p graf-after--p">But we didn’t find anything important….</p><figure name="8a17" id="8a17" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*6CXoA21oQDlD3I54lxxTKA.png" data-width="940" data-height="150" src="https://cdn-images-1.medium.com/max/800/1*6CXoA21oQDlD3I54lxxTKA.png"></figure><p name="b745" id="b745" class="graf graf--p graf-after--figure">So I’ll try to guess which Directory contains the debug page, so….</p><p name="ceef" id="ceef" class="graf graf--p graf-after--p">We will need a tool that helps us guess and also a large set of possibilities, so we will use the feroxbuster tool, and the list that we will use for guessing is the list for <a href="https://github.com/Bo0oM/fuzz.txt/blob/master/fuzz.txt" data-href="https://github.com/Bo0oM/fuzz.txt/blob/master/fuzz.txt" class="markup--anchor markup--p-anchor" rel="nofollow noopener" target="_blank">https://github.com/Bo0oM/fuzz.txt/blob/master/fuzz.txt</a><br>You can also download the feroxbuster tool from here: <a href="https://github.com/epi052/feroxbuster" data-href="https://github.com/epi052/feroxbuster" class="markup--anchor markup--p-anchor" rel="nofollow noopener" target="_blank">https://github.com/epi052/feroxbuster</a></p><figure name="a6a5" id="a6a5" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*myA5sbW5xFHEC2DFaEENWA.png" data-width="1012" data-height="334" src="https://cdn-images-1.medium.com/max/800/1*myA5sbW5xFHEC2DFaEENWA.png"></figure><pre data-code-block-mode="1" spellcheck="false" data-code-block-lang="bash" name="8f7a" id="8f7a" class="graf graf--pre graf-after--figure graf--preV2"><span class="pre--content">feroxbuster -u <span class="hljs-string">&quot;https://0a6d00b6036d1771808a99a1006a0080.web-security-academy.net/&quot;</span> -w /home/as/Desktop/fuzz.txt</span></pre><p name="2bfc" id="2bfc" class="graf graf--p graf-after--pre">Here&#39;s what each part means:</p><ul class="postList"><li name="0c0d" id="0c0d" class="graf graf--li graf-after--p"><code class="markup--code markup--li-code">feroxbuster</code>: This is the command to run FeroxBuster.</li><li name="aa2b" id="aa2b" class="graf graf--li graf-after--li"><code class="markup--code markup--li-code">-u &quot;https://0a6d00b6036d1771808a99a1006a0080.web-security-academy.net/&quot;</code>: This flag specifies the target URL to scan. In this case, it&#39;s the URL <code class="markup--code markup--li-code">https://0a6d00b6036d1771808a99a1006a0080.web-security-academy.net/</code>, which seems to be a web server belonging to Web Security Academy.</li><li name="f7ee" id="f7ee" class="graf graf--li graf-after--li"><code class="markup--code markup--li-code">-w /home/as/Desktop/fuzz.txt</code>: This flag specifies the wordlist (list of words) to use for fuzzing or directory and file discovery. It points to the file <code class="markup--code markup--li-code">/home/as/Desktop/fuzz.txt</code>, which is likely a text file containing a list of words that FeroxBuster will use to attempt to discover directories and files on the target website.</li></ul><p name="e89a" id="e89a" class="graf graf--p graf-after--li">In summary, this command tells FeroxBuster to scan the specified URL using the wordlist provided in <code class="markup--code markup--p-code">fuzz.txt</code> to discover directories and files on the target web server. This can be useful for security testing purposes to identify hidden or potentially vulnerable areas of a website.</p><figure name="c054" id="c054" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*HcXqaVCSo03pTR_iK4--WQ.png" data-width="1220" data-height="270" src="https://cdn-images-1.medium.com/max/800/1*HcXqaVCSo03pTR_iK4--WQ.png"></figure><p name="b84e" id="b84e" class="graf graf--p graf-after--figure">Finally we found the Directory, let’s look at it :</p><figure name="0e25" id="0e25" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*GbsDOHUDDxRw1Re8mFH1kA.png" data-width="1137" data-height="235" src="https://cdn-images-1.medium.com/max/800/1*GbsDOHUDDxRw1Re8mFH1kA.png"></figure><p name="8cbf" id="8cbf" class="graf graf--p graf-after--figure">We found a file that looks interesting :</p><figure name="4038" id="4038" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*IcR-bsS47BkfwACo46zrLg.png" data-width="1615" data-height="196" src="https://cdn-images-1.medium.com/max/800/1*IcR-bsS47BkfwACo46zrLg.png"></figure><p name="89b7" id="89b7" class="graf graf--p graf-after--figure">Here is the debugging page. You can search the page for the word “SECRET_KEY” and send the key until you finish the laptop. However, I solved this laptop in another way. You can follow the tick if you want to benefit.</p><blockquote name="87c3" id="87c3" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong">We can also look at the source code, for the site there may be more</strong></blockquote><figure name="3651" id="3651" class="graf graf--figure graf-after--blockquote"><img class="graf-image" data-image-id="1*NcRxU3ix1eROlmDoRZ5Drw.png" data-width="762" data-height="93" src="https://cdn-images-1.medium.com/max/800/1*NcRxU3ix1eROlmDoRZ5Drw.png"></figure><p name="48b0" id="48b0" class="graf graf--p graf-after--figure">Well there was this comment that said it was a comment containing a link to the <strong class="markup--strong markup--p-strong">“phpinfo.php”</strong> page, which displays information about the <strong class="markup--strong markup--p-strong">PHP</strong> settings. The code has been placed in a comment most likely for security reasons to prevent unauthorized access to sensitive server information.</p><blockquote name="ce95" id="ce95" class="graf graf--blockquote graf-after--p"><strong class="markup--strong markup--blockquote-strong">Since we found the debug page, we can now search for SECRET_KEY :</strong></blockquote><figure name="b0e2" id="b0e2" class="graf graf--figure graf-after--blockquote"><img class="graf-image" data-image-id="1*13_b-Axk4mxzxFF1DKK_lg.png" data-width="1235" data-height="967" src="https://cdn-images-1.medium.com/max/800/1*13_b-Axk4mxzxFF1DKK_lg.png"></figure><blockquote name="21e0" id="21e0" class="graf graf--blockquote graf-after--figure"><strong class="markup--strong markup--blockquote-strong">I will solve the entire lab this time using burp :</strong></blockquote><figure name="034a" id="034a" class="graf graf--figure graf-after--blockquote"><img class="graf-image" data-image-id="1*Utlbant9anS53xitq-A2vw.png" data-width="1121" data-height="624" src="https://cdn-images-1.medium.com/max/800/1*Utlbant9anS53xitq-A2vw.png"></figure><p name="5873" id="5873" class="graf graf--p graf-after--figure">When you connect your browser with burp, and then when you go to the “target” tab, you will find that file that we also found by guessing in Wordlist, and inside the file we will find the error correction page, so :</p><figure name="ad93" id="ad93" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*LQL-gckVTIzketlNZS7VGQ.png" data-width="644" data-height="481" src="https://cdn-images-1.medium.com/max/800/1*LQL-gckVTIzketlNZS7VGQ.png"></figure><p name="bf41" id="bf41" class="graf graf--p graf-after--figure">You will perform a “Sent to Repeater” on this GET request, and then you will send the request, and you will find the debugging page again:</p><figure name="257f" id="257f" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*ahqexo9M9llyQHn1GpqgxA.png" data-width="1560" data-height="807" src="https://cdn-images-1.medium.com/max/800/1*ahqexo9M9llyQHn1GpqgxA.png"></figure><p name="5dff" id="5dff" class="graf graf--p graf-after--figure">You will find the answer like this, so we will search for “SECRET_KEY” :</p><figure name="bb61" id="bb61" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*tmXYrLTChy_nYgo2_5TRqg.png" data-width="464" data-height="466" src="https://cdn-images-1.medium.com/max/800/1*tmXYrLTChy_nYgo2_5TRqg.png"><figcaption class="imageCaption">Congratulations on getting what you want for the second time .</figcaption></figure><blockquote name="b247" id="b247" class="graf graf--blockquote graf-after--figure"><strong class="markup--strong markup--blockquote-strong">See you soon in other reports….!!</strong></blockquote><blockquote name="378b" id="378b" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">Abdelwahab_Shandy</strong></blockquote><blockquote name="6903" id="6903" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong">AS_Cyber</strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/87709c05a153"><time class="dt-published" datetime="2024-04-27T19:50:55.427Z">April 27, 2024</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/lab-information-disclosure-on-debug-page-87709c05a153" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>