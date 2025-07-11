
# 🏛️ الباب الأول: **مقدمة عامة عن Windows**

---
## 🎯 ما هو Windows؟

**Windows** هو نظام تشغيل (Operating System) من تطوير شركة **Microsoft**، أُطلق لأول مرة في عام 1985 كواجهة رسومية لنظام MS-DOS، ومنذ ذلك الحين تطوّر ليصبح أشهر نظام تشغيل في العالم، خاصة للمستخدمين العاديين والشركات.

### ✅ أهم خصائصه:

- **واجهة رسومية GUI** : تسهّل التعامل مع النظام من خلال النوافذ، الأيقونات، القوائم.

- **سطر أوامر CLI** : يتيح تنفيذ أوامر متقدمة عبر PowerShell وCMD.

- **بيئة تشغيل شاملة** : يدعم تشغيل آلاف التطبيقات من البرمجيات المكتبية حتى أدوات الشبكات والتطوير والأمن.

---
## 📌 إصدارات Windows المهمة في المجال الأمني:

|الإصدار|ملاحظات أمنية|
|---|---|
|**Windows 7**|رغم توقف الدعم، لا زال مستخدمًا في بيئات اختبار الثغرات|
|**Windows 10**|الأكثر انتشارًا حاليًا بين الأفراد|
|**Windows 11**|تحديثات أمنية أفضل، لكنه لم يُستخدم بشكل واسع في بيئات المؤسسات بعد|
|**Windows Server**|يُستخدم في الشبكات المؤسسية والخوادم - مهم جدًا لفهم إدارة الأنظمة|

---
## 🎯 لماذا Windows مهم في مجال السايبر سيكيورتي؟

### 🔐 1. **الانتشار الواسع**:

- أكثر من 70% من أجهزة الحواسيب تستخدم Windows، لذلك هو الهدف الأول للهجمات.

- حتى أنظمة الشركات والبنوك تعتمد عليه في البيئات المكتبية.

### 🛠️ 2. **وجود أدوات أمنية متخصصة**:

- أدوات مثل **Sysinternals Suite**، و **Volatility**، و **Process Hacker**، و **FTK Imager**، كلها تدعم Windows.

- أدوات الـ **Forensics** و **Malware Analysis** غالبًا تعمل عليه أو تستهدفه.

### ⚔️ 3. **الاختراق والاستغلال**:

- كثير من الثغرات (مثل EternalBlue) أثرت على Windows.

- أدوات مثل **Metasploit** و **Empire** تستهدف خدمات أو ثغرات Windows.

### 📉 4. **التحقيق الجنائي الرقمي (Digital Forensics)**:

- تحليل الأنظمة المخترقة أو المصابة يتم على Windows في كثير من الحالات.

- فحص الريجستري (Registry)، ملفات الأحداث (Event Logs)، ملفات Pagefile، Prefetch، إلخ.

---
## 🧰 أدوات Windows المهمة في الأمن السيبراني

|الأداة|الاستخدام|
|---|---|
|**PowerShell**|أداة إدارة وتحكم قوية، تُستخدم أيضًا في الهجمات|
|**Event Viewer**|لمراقبة سجلات النظام والبرمجيات|
|**Task Manager**|تحليل العمليات والبرمجيات النشطة|
|**Regedit**|تحليل وتعديل الريجستري (مهم في الـForensics)|
|**Sysinternals**|مجموعة أدوات قوية لتحليل النظام (مثل Autoruns, Process Explorer)|
|**Windows Defender / Security Center**|أداة حماية مدمجة – تحتاج فهم آلية عملها|

---
## 💬 ملاحظات هامة:

- لا يُنظر إلى Windows على أنه فقط “نظام مستخدم”، بل هو بيئة اختراق وتحليل أيضًا.

- فهم Windows من الناحية الأمنية يتضمن معرفة:
    
    - كيف يعمل النظام داخليًا؟
    
    - أين تُخزن البيانات؟
    
    - كيف تُعالج الأحداث؟
    
    - ما هي الخدمات والبورتات النشطة؟

---
`Abdelwahab Shandy`