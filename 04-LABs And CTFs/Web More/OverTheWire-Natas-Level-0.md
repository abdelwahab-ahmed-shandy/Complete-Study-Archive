<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>OverTheWire : Natas : Level 0 :</title><style>
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
<h1 class="p-name">OverTheWire : Natas : Level 0 :</h1>
</header>
<section data-field="subtitle" class="p-summary">
Natas teaches the basics of serverside web-security.
</section>
<section data-field="body" class="e-content">
<section name="f464" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="922b" id="922b" class="graf graf--h3 graf--leading graf--title">OverTheWire : Natas : <a href="https://overthewire.org/wargames/natas/natas0.html" data-href="https://overthewire.org/wargames/natas/natas0.html" class="markup--anchor markup--h3-anchor" rel="noopener" target="_blank">Level 0</a> “)</h3><p name="5c50" id="5c50" class="graf graf--p graf-after--h3">Natas teaches the basics of serverside web-security.</p><p name="332c" id="332c" class="graf graf--p graf-after--p">Each level of natas consists of its own website located at <a href="http://natasX.natas.labs.overthewire.org," data-href="http://natasX.natas.labs.overthewire.org," class="markup--anchor markup--p-anchor" rel="noopener" target="_blank"><strong class="markup--strong markup--p-strong">http://natasX.natas.labs.overthewire.org</strong>,</a> where X is the level number. There is <strong class="markup--strong markup--p-strong">no SSH login</strong>. To access a level, enter the username for that level (e.g. natas0 for level 0) and its password.</p><p name="38d1" id="38d1" class="graf graf--p graf-after--p">Each level has access to the password of the next level. Your job is to somehow obtain that next password and level up. <strong class="markup--strong markup--p-strong">All passwords are also stored in /etc/natas_webpass/</strong>. E.g. the password for natas5 is stored in the file /etc/natas_webpass/natas5 and only readable by natas4 and natas5.</p><p name="a81b" id="a81b" class="graf graf--p graf-after--p">Start here:</p><pre data-code-block-mode="1" spellcheck="false" data-code-block-lang="makefile" name="7830" id="7830" class="graf graf--pre graf-after--p graf--preV2"><span class="pre--content"><span class="hljs-section">Username: natas0</span><br /><span class="hljs-section">Password: natas0</span><br /><span class="hljs-section">URL:      http://natas0.natas.labs.overthewire.org</span></span></pre><figure name="4f24" id="4f24" class="graf graf--figure graf-after--pre"><img class="graf-image" data-image-id="1*SiNfXbcbWjW_ZEiNHrGGMg.png" data-width="665" data-height="156" src="https://cdn-images-1.medium.com/max/800/1*SiNfXbcbWjW_ZEiNHrGGMg.png"><figcaption class="imageCaption">Natas 0 :</figcaption></figure><p name="660b" id="660b" class="graf graf--p graf-after--figure">To go to the challenge :</p><figure name="3189" id="3189" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*uNZkNOH8On4NMXgsFsG5rA.png" data-width="430" data-height="355" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*uNZkNOH8On4NMXgsFsG5rA.png"></figure><p name="8c87" id="8c87" class="graf graf--p graf-after--figure">You will find a page like this :</p><figure name="de52" id="de52" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*wcEHc3YFVoTWC4Xjn_uRmA.png" data-width="1325" data-height="478" src="https://cdn-images-1.medium.com/max/800/1*wcEHc3YFVoTWC4Xjn_uRmA.png"></figure><p name="49a6" id="49a6" class="graf graf--p graf-after--figure">You will right click &gt; then &gt; view page source :</p><figure name="fff0" id="fff0" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*7BPirZsDWbZJVoB60XB-4Q.png" data-width="366" data-height="434" src="https://cdn-images-1.medium.com/max/800/1*7BPirZsDWbZJVoB60XB-4Q.png"></figure><p name="9d0b" id="9d0b" class="graf graf--p graf-after--figure">Here is what is required for the next round :</p><figure name="f1a1" id="f1a1" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*fqZeeFHJK9rWGewgKs95yQ.png" data-width="1091" data-height="377" src="https://cdn-images-1.medium.com/max/800/1*fqZeeFHJK9rWGewgKs95yQ.png"></figure><p name="c011" id="c011" class="graf graf--p graf-after--figure">We meet in the future….!</p><p name="bed6" id="bed6" class="graf graf--p graf-after--p">I’ll see you later…..!</p><p name="a969" id="a969" class="graf graf--p graf-after--p">Abdelwahab_Shandy</p><p name="118e" id="118e" class="graf graf--p graf-after--p graf--trailing">AS_Cyber……”)</p></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/60ffd86bfd39"><time class="dt-published" datetime="2023-11-25T23:54:21.120Z">November 25, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/overthewire-natas-level-0-60ffd86bfd39" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>