# وسائل النقل السلكية (Wired Transmission Media)

## مقدمة
وسائط النقل السلكية تعد العمود الفقري للشبكات الحاسوبية، حيث يتم من خلالها نقل البيانات عبر الكابلات بين الأجهزة. تنقسم هذه الوسائط إلى نوعين رئيسيين هما:
1. الكابلات النحاسية (Copper Cables).
2. كابلات الألياف الضوئية (Fiber Optic Cables).

---

## أولاً: الكابلات النحاسية (Copper Cables)

### 1. الكابل المحوري (Coaxial Cable)
- 📺 كان يُستخدم في الماضي في شبكات الحاسوب ولكنه الآن يقتصر غالبًا على:
  - شبكات التلفزيون (Cable TV).
  - أنظمة استقبال الأقمار الصناعية.
- يحتوي على:
  - موصل نحاسي داخلي.
  - طبقة عازلة.
  - شبكة معدنية خارجية للحماية من التداخل الكهرومغناطيسي.
- يستخدم وصلات من نوع **BNC**.
- أهم مميزاته:
  - مقاومة جيدة للتداخل الكهرومغناطيسي (EMI).
  - قدرة عالية على نقل البيانات لمسافات متوسطة.
- عيوبه:
  - غير مرن وصعب التمديد.
  - أغلى تكلفة مقارنة بوسائط أخرى.

---

### 2. الكابل المزدوج المجدول (Twisted Pair Cable)
يتكون من زوج أو أكثر من الأسلاك النحاسية الملتفة معًا، ويوجد منه نوعان:

#### أ. الكابل المزدوج غير المحمي (Unshielded Twisted Pair - UTP)
- 📶 الأكثر استخدامًا في شبكات الحاسوب (LAN).
- مميزاته:
  - خفيف الوزن.
  - سهل التركيب.
  - منخفض التكلفة.
  - يقاوم التداخل بشكل مقبول بفضل التفاف الأزواج.
- يستخدم موصلات من نوع **RJ-45**.
- الفئات (Categories):
  - **Cat 1**: صوت فقط (غير مستخدم للشبكات).
  - **Cat 3**: نقل بيانات بسرعة تصل 10 Mbps.
  - **Cat 5e**: دعم شبكات Ethernet بسرعة 1 Gbps.
  - **Cat 6 / 6a**: دعم سرعات تصل إلى 10 Gbps لمسافات قصيرة.
  - **Cat 7 / 8**: دعم سرعات أعلى ومسافات أطول.

#### ب. الكابل المزدوج المحمي (Shielded Twisted Pair - STP)
- مزود بطبقة حماية إضافية ضد التداخل.
- أغلى من UTP وأصعب في التركيب.
- يستخدم في الأماكن ذات التداخل الكهرومغناطيسي العالي (مثل المصانع).

---

## ثانيًا: كابلات الألياف الضوئية (Fiber Optic Cables)

- ⚡ تعتمد على نقل الضوء بدلاً من الإشارات الكهربائية، مما يجعلها:
  - منيعة تمامًا ضد التداخل الكهرومغناطيسي (EMI).
  - قادرة على نقل البيانات لمسافات طويلة جدًا بسرعات عالية.
- التركيب:
  - نواة (Core) مصنوعة من الزجاج أو البلاستيك.
  - غلاف عاكس (Cladding) يحافظ على الضوء داخل النواة.
  - طبقات واقية إضافية ضد الرطوبة والكسر.

### أنواع الألياف الضوئية:
#### أ. الألياف أحادية النمط (Single-Mode Fiber - SMF)
- 💡 قطر النواة: حوالي 9 ميكرون.
- تستخدم لنقل البيانات لمسافات طويلة (حتى 100 كم وأكثر).
- مكلفة وتحتاج أجهزة إرسال/استقبال دقيقة.
- مثالية للشبكات بين المدن والقارات (Submarine Cables).

#### ب. الألياف متعددة النمط (Multi-Mode Fiber - MMF)
- 💡 قطر النواة: حوالي 50 ميكرون.
- تستخدم للمسافات القصيرة (حتى 2 كم تقريبًا).
- أرخص وأسهل في التركيب.
- مثالية للشبكات داخل المباني أو بين أجنحة مبنى واحد.

---

## مقارنة شاملة بين الوسائط السلكية:

| المعايير                  | Coaxial Cable    | Twisted Pair (UTP/STP) | Fiber Optic      |
|--------------------------|-----------------|------------------------|-----------------|
| التكلفة                  | متوسطة          | منخفضة (UTP) / متوسطة (STP) | مرتفعة          |
| المرونة وسهولة التركيب    | صعبة            | سهلة جداً (UTP)        | معقدة وتتطلب خبرة |
| مقاومة التداخل (EMI)      | جيدة            | متوسطة (UTP) / جيدة (STP) | ممتازة          |
| المسافة القصوى          | متوسطة (~500 م) | قصيرة (100 م تقريباً)  | طويلة جداً (كيلومترات) |
| السرعة الممكنة           | متوسطة (حتى 10 Mbps) | عالية (حتى 10 Gbps وما فوق حسب الفئة) | عالية جداً (حتى Terabits/s) |
| مجالات الاستخدام         | التلفزيون، الأقمار الصناعية | الشبكات المحلية، مكاتب | الشبكات الكبرى، الإنترنت العالمي |

---

## ملاحظات إضافية (Did You Know?)

- 🌐 أكثر من 99% من حركة الإنترنت العالمية تمر عبر كابلات الألياف الضوئية تحت البحار.
- ⚠️ يمكن للألياف الضوئية أن تتأثر بالثني المفرط مما يضعف أو يقطع الإشارة.
- 🔄 بعض شبكات المدن الكبرى تستخدم مزيجًا من الألياف الضوئية في العمود الفقري (Backbone) وكابلات UTP للاتصال الداخلي في الأبنية.

---

## خلاصة
وسائط النقل السلكية تمثل الأساس الذي تقوم عليه شبكات الحاسوب في العالم، ويؤثر اختيار الوسيط المناسب على:
- جودة الاتصال.
- سرعة نقل البيانات.
- المسافة المغطاة.
- مستوى الأمان ضد التداخلات البيئية.

مع تقدم التقنية، تستمر الألياف الضوئية في السيطرة على شبكات المسافات الطويلة، بينما تبقى الكابلات النحاسية الخيار الأفضل للشبكات القصيرة والمتوسطة بفضل تكلفتها المناسبة وسهولة تركيبها.

---

---

# Wired Transmission Media

## Introduction
Wired transmission media are the backbone of computer networks, through which data is transmitted between devices via cables. These media are divided into two main types:
1. Copper Cables
2. Fiber Optic Cables

---

## First: Copper Cables

### 1. Coaxial Cable
- 📺 It was used in the past in computer networks, but is now mostly limited to:
- Cable TV networks
- Satellite reception systems
- It contains:
- An internal copper conductor
- An insulating layer
- An external metal mesh for protection against electromagnetic interference
- It uses BNC connectors.
- Its most important features:
- Good resistance to electromagnetic interference (EMI).
- High data transmission capacity over medium distances.
- Disadvantages:
- Inflexible and difficult to extend.
- More expensive compared to other media.

---

### 2. Twisted Pair Cable
Consists of one or more pairs of copper wires twisted together. There are two types:

#### A. Unshielded Twisted Pair (UTP) Cable
- 📶 Most commonly used in computer networks (LANs).
- Advantages:
- Light weight.
- Easy to install.
- Low cost.
- Acceptably resistant to interference due to the twisting of the pairs.
- Uses RJ-45 connectors.
- Categories:
- **Cat 1**: Voice only (not used for networks).
- **Cat 3**: Data transmission speeds up to 10 Mbps.
- **Cat 5e**: Supports Ethernet networks at 1 Gbps. - **Cat 6/6a**: Supports speeds up to 10 Gbps for short distances.
- **Cat 7/8**: Supports higher speeds and longer distances.

#### B. Shielded Twisted Pair (STP) Cable
- Provides an additional layer of protection against interference.
- More expensive than UTP and more difficult to install.
- Used in areas with high electromagnetic interference (such as factories).

---
## Second: Fiber Optic Cables

- ⚡ They rely on the transmission of light rather than electrical signals, making them:
- Completely immune to electromagnetic interference (EMI).
- Capable of transmitting data over very long distances at high speeds.
- Construction:
- Core made of glass or plastic.
- Reflective cladding keeps light inside the core.
- Additional protective layers against moisture and breakage.

### Types of Optical Fibers:
#### A. Single-Mode Fiber (SMF)
- 💡 Core Diameter: approximately 9 microns.
- Used for long-distance data transmission (up to 100 km or more).
- Expensive and requires precise transceivers.
- Ideal for intercity and intercontinental networks (submarine cables).

#### B. Multi-Mode Fiber (MMF)
- 💡 Core Diameter: approximately 50 microns.
- Used for short distances (up to approximately 2 km).
- Cheaper and easier to install.
- Ideal for networks within buildings or between wings of a single building.

---
## Comprehensive Comparison of Wired Media:

| Standards | Coaxial Cable | Twisted Pair (UTP/STP) | Fiber Optic |
|- ... - ⚠️ Optical fibers can be affected by excessive bending, which weakens or interrupts the signal.
- 🔄 Some major urban networks use a combination of optical fibers in the backbone and UTP cables for internal communication within buildings.

---

## Summary
Wired transmission media represent the foundation of computer networks worldwide, and choosing the appropriate medium affects:
- Connection quality.
- Data transmission speed.
- Distance covered.
- Security against environmental interference.

As technology advances, optical fiber continues to dominate long-distance networks, while copper cables remain the preferred choice for short- and medium-distance networks due to their affordability and ease of installation.

---

### By Abdelwahab Shandy 