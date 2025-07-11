<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>CTFLEARN:Snowboard</title><style>
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
<h1 class="p-name">CTFLEARN:Snowboard</h1>
</header>
<section data-field="subtitle" class="p-summary">
Forensics
</section>
<section data-field="body" class="e-content">
<section name="f5e5" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="a093" id="a093" class="graf graf--h3 graf--leading graf--title">CTFLEARN:Snowboard</h3><p name="f362" id="f362" class="graf graf--p graf-after--h3"><strong class="markup--strong markup--p-strong">Forensics</strong></p><figure name="92c9" id="92c9" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*lUcOIsgP6kQUwhK6WjR3kg.png" data-width="747" data-height="624" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*lUcOIsgP6kQUwhK6WjR3kg.png"></figure><p name="4449" id="4449" class="graf graf--p graf-after--figure"><a href="https://ctflearn.com/challenge/934" data-href="https://ctflearn.com/challenge/934" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Challenge — Snowboard — CTFlearn — CTF Practice — CTF Problems — CTF Challenges</a></p><p name="9d9c" id="9d9c" class="graf graf--p graf-after--p">Find the flag in the jpeg file. Good Luck!</p><p name="0492" id="0492" class="graf graf--p graf-after--p"><a href="https://ctflearn.com/challenge/download/934" data-href="https://ctflearn.com/challenge/download/934" class="markup--anchor markup--p-anchor" rel="noopener" target="_blank">Snowboard.jpg</a></p><p name="a21f" id="a21f" class="graf graf--p graf-after--p">Don’t forget we always work inside VMs .</p><p name="4341" id="4341" class="graf graf--p graf-after--p">So we’ll upload the file there and then :</p><p name="5515" id="5515" class="graf graf--p graf-after--p">We took the download link and used <strong class="markup--strong markup--p-strong">wget </strong>to download the :</p><figure name="ce39" id="ce39" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*lzM8VsmBPEzmENcaYKsDIQ.png" data-width="683" data-height="320" src="https://cdn-images-1.medium.com/max/800/1*lzM8VsmBPEzmENcaYKsDIQ.png"></figure><p name="c251" id="c251" class="graf graf--p graf-after--figure">I always change the names to something that is closest to what we do, so I changed the name of the file to the name of the task that we are doing now , Now let’s get started :</p><figure name="f2a3" id="f2a3" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*bYX9cfs_MSKxXmHEhQ4q5w.png" data-width="680" data-height="250" src="https://cdn-images-1.medium.com/max/800/1*bYX9cfs_MSKxXmHEhQ4q5w.png"></figure><p name="cd3c" id="cd3c" class="graf graf--p graf-after--figure">Here we define the <strong class="markup--strong markup--p-strong">file </strong>type , There are a lot of interesting things :</p><figure name="7b72" id="7b72" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*jFf1B5NKeJNADpjBB_dJLg.png" data-width="682" data-height="136" src="https://cdn-images-1.medium.com/max/800/1*jFf1B5NKeJNADpjBB_dJLg.png"></figure><p name="d9dd" id="d9dd" class="graf graf--p graf-after--figure">Let’s search using <strong class="markup--strong markup--p-strong">strings :</strong></p><figure name="05f9" id="05f9" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*LmTax9WV8vIHUUZwmQ_tCA.png" data-width="682" data-height="408" src="https://cdn-images-1.medium.com/max/800/1*LmTax9WV8vIHUUZwmQ_tCA.png"></figure><p name="e18f" id="e18f" class="graf graf--p graf-after--figure">The command <code class="markup--code markup--p-code"><strong class="markup--strong markup--p-strong">strings Snowboard.jpg | head -n 20</strong></code> is used to extract printable characters (human-readable strings) from the binary content of the file &quot;Snowboard.jpg&quot; and display the first 20 lines of those strings.</p><p name="7d15" id="7d15" class="graf graf--p graf-after--p">Let’s break down the components of the command:</p><ul class="postList"><li name="77bd" id="77bd" class="graf graf--li graf-after--p"><code class="markup--code markup--li-code"><strong class="markup--strong markup--li-strong">strings Snowboard.jpg</strong></code>: This part of the command runs the <code class="markup--code markup--li-code">strings</code> command on the file &quot;Snowboard.jpg&quot;. The <code class="markup--code markup--li-code">strings</code> command looks for sequences of printable characters in binary files.</li><li name="24bb" id="24bb" class="graf graf--li graf-after--li"><code class="markup--code markup--li-code"><strong class="markup--strong markup--li-strong">|</strong></code>: This is a pipe symbol, which is used to pass the output of the command on its left as input to the command on its right.</li><li name="fb77" id="fb77" class="graf graf--li graf-after--li"><code class="markup--code markup--li-code"><strong class="markup--strong markup--li-strong">head -n 20</strong></code>: This part of the command takes the output of the <code class="markup--code markup--li-code">strings</code> command and displays only the first 20 lines using the <code class="markup--code markup--li-code">head</code> command.</li></ul><figure name="5b75" id="5b75" class="graf graf--figure graf-after--li"><img class="graf-image" data-image-id="1*mx_bDWqxP0I3LeLsoxd4fA.png" data-width="523" data-height="88" src="https://cdn-images-1.medium.com/max/800/1*mx_bDWqxP0I3LeLsoxd4fA.png"></figure><p name="6c4e" id="6c4e" class="graf graf--p graf-after--figure">The command <code class="markup--code markup--p-code"><strong class="markup--strong markup--p-strong">echo &quot;Q1RGbGVhcm57U2tpQmFuZmZ9Cg==&quot; | base64 --decode</strong></code> decodes the base64-encoded string <strong class="markup--strong markup--p-strong">&quot;Q1RGbGVhcm57U2tpQmFuZmZ9Cg==&quot; </strong>using the <code class="markup--code markup--p-code"><strong class="markup--strong markup--p-strong">base64</strong></code> command. Here&#39;s a breakdown of the components:</p><ul class="postList"><li name="8590" id="8590" class="graf graf--li graf-after--p"><code class="markup--code markup--li-code"><strong class="markup--strong markup--li-strong">echo &quot;Q1RGbGVhcm57U2tpQmFuZmZ9Cg==&quot;</strong></code>: This part of the command echoes the base64-encoded string to the standard output.</li><li name="be3e" id="be3e" class="graf graf--li graf-after--li"><code class="markup--code markup--li-code"><strong class="markup--strong markup--li-strong">|</strong></code>: This is a pipe symbol, which is used to pass the output of the command on its left as input to the command on its right.</li><li name="d7a6" id="d7a6" class="graf graf--li graf-after--li"><code class="markup--code markup--li-code"><strong class="markup--strong markup--li-strong">base64 --decode</strong></code>: This part of the command uses the <code class="markup--code markup--li-code">base64</code> command with the <code class="markup--code markup--li-code">--decode</code> option to decode the base64-encoded string.</li></ul><h4 name="a139" id="a139" class="graf graf--h4 graf-after--li"><strong class="markup--strong markup--h4-strong">You can also use </strong><a href="https://cyberchef.org/" data-href="https://cyberchef.org/" class="markup--anchor markup--h4-anchor" rel="nofollow noopener" target="_blank"><strong class="markup--strong markup--h4-strong">https://cyberchef.org/</strong></a><strong class="markup--strong markup--h4-strong"> to extract the flag</strong></h4><blockquote name="1b28" id="1b28" class="graf graf--blockquote graf-after--h4"><strong class="markup--strong markup--blockquote-strong">Here is the flag<br>See you soon in other reports….!!</strong></blockquote><blockquote name="25f2" id="25f2" class="graf graf--blockquote graf-after--blockquote"><strong class="markup--strong markup--blockquote-strong">Abdelwahab_Shandy</strong></blockquote><blockquote name="a554" id="a554" class="graf graf--blockquote graf-after--blockquote graf--trailing"><strong class="markup--strong markup--blockquote-strong">AS_Cyber</strong></blockquote></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/2bf9af2a7cac"><time class="dt-published" datetime="2023-12-17T15:28:58.344Z">December 17, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/ctflearn-snowboard-2bf9af2a7cac" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>