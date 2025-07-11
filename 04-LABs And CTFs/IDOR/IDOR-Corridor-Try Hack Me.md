<!DOCTYPE html><html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"><title>Corridor : Try Hack Me</title><style>
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
<h1 class="p-name">Corridor : Try Hack Me</h1>
</header>
<section data-field="subtitle" class="p-summary">
Escape the Corridor :
You have found yourself in a strange corridor. Can you find your way back to where
you came?
In this challenge, you…
</section>
<section data-field="body" class="e-content">
<section name="c9de" class="section section--body section--first section--last"><div class="section-divider"><hr class="section-divider"></div><div class="section-content"><div class="section-inner sectionLayout--insetColumn"><h3 name="449d" id="449d" class="graf graf--h3 graf--leading graf--title">Corridor : Try Hack Me</h3><p name="a1da" id="a1da" class="graf graf--p graf-after--h3">Escape the Corridor :You have found yourself in a strange corridor. Can you find your way back to whereyou came?<br>In this challenge, you will explore potential IDOR vulnerabilities. Examine the URL endpoints you access as you navigate the website and note the hexadecimal values you find (they look an awful lot like a<br>hash, don’t they?). This could help you uncover website locations you were not expected to access</p><figure name="6fac" id="6fac" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*zDxO0GUWN-LZJ6JVmxciLA.png" data-width="687" data-height="510" data-is-featured="true" src="https://cdn-images-1.medium.com/max/800/1*zDxO0GUWN-LZJ6JVmxciLA.png"><figcaption class="imageCaption">What is the flag ..!?</figcaption></figure><p name="e454" id="e454" class="graf graf--p graf-after--figure">What is the flag?<br>Flag{################################}</p><p name="a2a9" id="a2a9" class="graf graf--p graf-after--p">Insecure Direct Object References (IDOR) is a type of security vulnerability that occurs<br>when an application allows an attacker to access a protected resource by modifying the<br>value of a parameter that references the resource. For example, an IDOR vulnerability<br>could allow an attacker to view the profile of another user by changing the user_id<br>parameter in a URL.<br>-First, we connected the machine and obtained the server’s IP .<br>-Then I put the IP on the browser, and this was the result :</p><figure name="c63c" id="c63c" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*AYBkKcLC1P6uNLSD-k0wXg.png" data-width="529" data-height="305" src="https://cdn-images-1.medium.com/max/800/1*AYBkKcLC1P6uNLSD-k0wXg.png"><figcaption class="imageCaption">So where is the key?</figcaption></figure><p name="a250" id="a250" class="graf graf--p graf-after--figure">When I was hovering over these doors with my mouse, I noticed that each door has a<br>different path with different numbers , I had to look at the code for the page .</p><figure name="de7a" id="de7a" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*xNmk7uMWaVF96eAFeENsCA.png" data-width="235" data-height="185" src="https://cdn-images-1.medium.com/max/800/1*xNmk7uMWaVF96eAFeENsCA.png"></figure><figure name="dd80" id="dd80" class="graf graf--figure graf-after--figure"><img class="graf-image" data-image-id="1*BIOKnHV5I7xbL71vmiCTNQ.png" data-width="527" data-height="292" src="https://cdn-images-1.medium.com/max/800/1*BIOKnHV5I7xbL71vmiCTNQ.png"></figure><ul class="postList"><li name="d928" id="d928" class="graf graf--li graf-after--figure">After opening the source code, I found the codes in this form, so I decided to check<br>them , i took all this to Note and then went to search and find out what kind of hash<br>it is , went to<br><a href="https://www.tunnelsup.com/hash-analyzer/" data-href="https://www.tunnelsup.com/hash-analyzer/" class="markup--anchor markup--li-anchor" rel="nofollow noopener" target="_blank">https://www.tunnelsup.com/hash-analyzer/</a></li></ul><figure name="355b" id="355b" class="graf graf--figure graf-after--li"><img class="graf-image" data-image-id="1*HHqgiSshuC5UelSYRp4r5g.png" data-width="472" data-height="313" src="https://cdn-images-1.medium.com/max/800/1*HHqgiSshuC5UelSYRp4r5g.png"></figure><p name="857c" id="857c" class="graf graf--p graf-after--figure">I learned that the hash type (MD4 or MD5) , went to<br><a href="https://crackstation.net/" data-href="https://crackstation.net/" class="markup--anchor markup--p-anchor" rel="nofollow noopener" target="_blank">https://crackstation.net/</a></p><ul class="postList"><li name="902a" id="902a" class="graf graf--li graf-after--p">This was the result :</li></ul><figure name="b702" id="b702" class="graf graf--figure graf-after--li"><img class="graf-image" data-image-id="1*MZOX_l-X7hzcfW5STY4qdw.png" data-width="642" data-height="258" src="https://cdn-images-1.medium.com/max/800/1*MZOX_l-X7hzcfW5STY4qdw.png"></figure><p name="b9c3" id="b9c3" class="graf graf--p graf-after--figure">-From here I was sure it was over MD5 , But we should note something important here,the Resalt is equal to 1 .<br>-Well I have to see the result of the rest of the hashtags :</p><figure name="c86e" id="c86e" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*9V8AElgKWV3EsLw1Z1QZ4A.png" data-width="659" data-height="482" src="https://cdn-images-1.medium.com/max/800/1*9V8AElgKWV3EsLw1Z1QZ4A.png"></figure><ul class="postList"><li name="795b" id="795b" class="graf graf--li graf-after--figure">Well, the results here are sequential in numbers from 1 to 13 by the number of doors ,<br>We felt that since this room is under the name of the IDOR vulnerability, I decided to<br>put the numbers one behind the second behind the IP in the URL :</li></ul><figure name="7432" id="7432" class="graf graf--figure graf-after--li"><img class="graf-image" data-image-id="1*g8m7g_0yjPL461Ja0cQX4w.png" data-width="532" data-height="153" src="https://cdn-images-1.medium.com/max/800/1*g8m7g_0yjPL461Ja0cQX4w.png"></figure><p name="e91b" id="e91b" class="graf graf--p graf-after--figure">-Well,it seems to be something else, but do not forget that it is the IDOR<br>vulnerability,So we will try numbers before 1 and after 13 ,Well it didn’t work .<br>-But the hash result was from 1 to 13, so we will make a hash MD5 For number 14 At<a href="https://gchq.github.io/CyberChef" data-href="https://gchq.github.io/CyberChef" class="markup--anchor markup--p-anchor" rel="nofollow noopener" target="_blank">https://gchq.github.io/CyberChef</a></p><figure name="e0fd" id="e0fd" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*w_ffvxe_Z5QyNLZK8w6t7Q.png" data-width="585" data-height="346" src="https://cdn-images-1.medium.com/max/800/1*w_ffvxe_Z5QyNLZK8w6t7Q.png"></figure><p name="9863" id="9863" class="graf graf--p graf-after--figure">-Then I tried it again by hashing it to the URL until I found the flag , But it didn’t work</p><figure name="008c" id="008c" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*eymN4xkUJNVrQGzmjYn37Q.png" data-width="594" data-height="344" src="https://cdn-images-1.medium.com/max/800/1*eymN4xkUJNVrQGzmjYn37Q.png"></figure><p name="85e4" id="85e4" class="graf graf--p graf-after--figure">-Then bring the hash of number 0 ( cfcd208495d565ef66e7dff9f98764da ) .<br>-Then try the hash of number 0 with the URL .<br>-Hey, it worked</p><figure name="faa5" id="faa5" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*AY7iB-EeYeO27UJ4jcPIAA.png" data-width="659" data-height="176" src="https://cdn-images-1.medium.com/max/800/1*AY7iB-EeYeO27UJ4jcPIAA.png"></figure><p name="ca57" id="ca57" class="graf graf--p graf-after--figure">Flag: flag{2477##########################2e}</p><figure name="217f" id="217f" class="graf graf--figure graf-after--p"><img class="graf-image" data-image-id="1*rEvpzZpL6q_ezmrIz-FnYg.png" data-width="614" data-height="528" src="https://cdn-images-1.medium.com/max/800/1*rEvpzZpL6q_ezmrIz-FnYg.png"></figure><p name="5e07" id="5e07" class="graf graf--p graf-after--figure">Here are some additional tips for preventing IDOR<br>vulnerabilities:<br>•Use parameterized queries instead of direct object references in database queries.<br>•Use input validation to prevent attackers from injecting malicious code into parameters.<br>•Use strong authentication and authorization mechanisms to protect resources.<br>•Regularly scan your applications for IDOR vulnerabilities.</p><p name="5145" id="5145" class="graf graf--p graf-after--p">see you soon</p><p name="e5af" id="e5af" class="graf graf--p graf-after--p">Abdelwahab_Shandy</p><p name="6de6" id="6de6" class="graf graf--p graf-after--p graf--trailing">AS_Cyber</p></div></div></section>
</section>
<footer><p>By <a href="https://medium.com/@abdelwahabshandy" class="p-author h-card">Abdelwahab Shandy 🦅</a> on <a href="https://medium.com/p/39d3d7466ec1"><time class="dt-published" datetime="2023-11-21T23:46:43.137Z">November 21, 2023</time></a>.</p><p><a href="https://medium.com/@abdelwahabshandy/corridor-try-hack-me-39d3d7466ec1" class="p-canonical">Canonical link</a></p><p>Exported from <a href="https://medium.com">Medium</a> on July 8, 2025.</p></footer></article></body></html>