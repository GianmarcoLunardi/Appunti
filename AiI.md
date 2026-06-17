
Predictive and generative AI are related in that they use similar learning
techni ues, but substantially different in terms of what they’re designed to
achieve. In essence, predictive AI predicts future outcomes, whereas
generative AI creates new outcomes. Predictive AI is smart, but generative
AI is creative. Both have their place in our collective future.

Adobe Firefly: https://firefly.adobe.com
Agenta: https://agenta.ai
AIVA: https://www.aiva.ai
Artlist: https://artlist.io
Azure AI Foundry: https://ai.azure.com
Beatoven: https://www.beatoven.ai
BetterPrompt: https://www.betterprompt.com
Boomy: https://boomy.com
Canva AI: https://www.canva.com
ChatGPT: https://chatgpt.com
Choruz: https://choruz.ai
Claude: https://claude.ai
Deep Dream Generator: https://deepdreamgenerator.com
DeepAI: https://deepai.org
DeepSeek: https://www.deepseek.com
DreamStudio: https://dreamstudio.ai
Google Gemini: https://gemini.google.com
Grok: https://x.com/i/grok
Hailuo AI: https://www.hailuoai.com
Hotpot: https://hotpot.ai
Jasper: https://www.jasper.ai
Kling AI: https://klingai.com
Luma Dream Machine: https://lumalabs.ai/dream-machine
Loudly: https://www.loudly.com
Meta AI: https://www.meta.ai
Microsoft Bing Image Creator: https://www.bing.com/images/create
Microsoft Copilot: https://copilot.microsoft.com
Midjourney: https://www.midjourney.com
Mureka: https://mureka.ai
NightCafe: https://creator.nightcafe.studio
OpenArt: https://openart.ai
Paperpal: https://paperpal.com
Perplexity: https://www.perplexity.ai
Pi: https://pi.ai
Poe: https://poe.com
PromptHub: https://prompthub.us
PromptLayer: https://promptlayer.com
PromptPerfect: https://promptperfect.jina.ai
Riffusion: https://www.riffusion.com
Runway: https://runwayml.com
Rytr: https://rytr.me
Sora: https://openai.com/index/sora
Soundful: https://soundful.com
Soundraw: https://soundraw.ai
Sudowrite: https://www.sudowrite.com
Suno: https://suno.com
Udio: https://www.udio.com
Vidu: https://www.vidu.ai


** Necessary Components of an AI Prompt

Whether you’re asking for text, image, or video output, your AI prompt
needs to include the same basic components. These components include
_Task:_ Scrivi , analizza, riassumi ,selezioni, il compito che deve fare
_Format:_ il formato con cui si desidera l output esempio , documento test, word, excell, una lettera, 
Topic: l argomento sul quale lavorerà IA, Scrivi una lettara sul giardinaggio
presented in the task—write a paper about topic, answer a uestion
about topic, or create a photo of a topic.
_Tone or style:_ Lettera Professionale, lettera amichevole, instruzioni per un manuale
_Context:_ contesto in cui verrà letto il testo esempio, scuola superiore, oppure da un giudicie,
audience, or situation.
Restrinzioni : cose che non si vogliono faccia


** Tipi di Prompt

** Zero-Shot Prompting
Zero-shot prompting is the type of prompting with which you’re probably
most accustomed. With ero-shot prompting, all you do is describe the task
at hand. You don’t include any examples, just tell the AI model what you
want it to do.

Es:
(write a poem in the style of Edgar Allen Poe’s The Raven)
or in an accompanying file or webpage (write an article a out J.S. Bach
in the style of the one at this we page: [URL]

** Role-Based Prompting
Sometimes you get better results if you tell the AI model to assume a role or
persona when providing an answer. This is called role-based prompting, and
it helps to assign to the AI the tone or style (or even expertise) of a given
individual or role.

assume the role of an elementary school teacher and explain how
clouds make it rain

** Chain-of-Thought Prompting
Chain-of-thought prompting is often used when solving math and logic
problems, or in any instance that re uires multistep reasoning.
The following prompt is an example of chain-of-thought prompting:
Alice is older than Bo . Bo is older than Charlie. Who is the oldest?
Think it through step y step.

* [task] [format] [topic] [tone] [context] [re uirements/constraints]
[optional elements]

providing an example of what you want and how you want it. You
learned how one-shot prompting works and the various ways to reference
examples in your prompts. Exaples can be,_web pages_, documets, others file

Task: Generate a log post for our client, [CLIENT NAME]. Here is
some information a out the client:
[CLIENT DESCRIPTION]
Here are some previous log posts we’ve created for the client:
Example 1
Topic: [TOPIC]
Blog post: [BLOG POST CONTENT]
Example 2
Topic: [TOPIC]
Blog post: [BLOG POST CONTENT]
Write a 1,000-word log post a out [NEW TOPIC].


** Using Role-Based Prompting
Assume you are a [ROLE]. [PROMPT]
CEO or other senior manager, for developing business plans and
making important business decisions. Example: You are the CEO of a
mid-sized technology company facing declining customer retention.
Analyze the situation and propose a high-level strategic plan to
improve retention, focusing on customer experience and new
product development

** Using Chain-of-Thought Prompting
With prompt chaining, multiple prompts are
linked together in a se uence, with the output of one prompt used as the
input for the next.

** Using Self-Consistency Prompting
This strategy works by prompting the AI model multiple times—asking the
same uestion but letting the AI model produce different reasoning chains
with different degrees of randomness. This approach works best with chain
of-thought prompts, so you can see the reasoning used in each attempt.
