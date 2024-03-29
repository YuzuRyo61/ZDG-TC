# ZDG-TC

*TRAIN CREW Mascon adapter software*

株式会社瑞起 (英語表記 ZUIKI Inc.)から発売されているコントローラー、
「電車でGO!!専用ワンハンドルコントローラー for Nintendo Switch™」(ZKNS-001/ZKNS-002)を
acty(溝月レイル)が開発している「TRAIN CREW」で使えるようにするためのソフトウェアです。

「電車でGO!!専用ワンハンドルコントローラー for Nintendo Switch™」について:
https://www.zuiki.co.jp/mascon-excl/

TRAIN CREWについてはこちら:
https://acty-soft.com/traincrew/

# ダウンロード

本GitHubリポジトリのReleasesからダウンロードいただけます。

https://github.com/YuzuRyo61/ZDG-TC/releases/latest

# 使い方

0. SteamでTRAIN CREWを所有している必要があります。所有していない場合は、Steamストアから入手できます。
   
   https://store.steampowered.com/app/1618290/TRAIN_CREW/
1. Steamライブラリから「TRAIN CREW」を右クリックしプロパティを開き、「コントローラ」にある、Steam入力を「デフォルト設定に使用する」もしくは「Steam入力を有効にする」に変更します。
2. 「TRAIN CREW」を開き、Steamのオーバーレイを開いて、「コントローラ設定」をクリックして設定を開きます。

   コントローラ設定でSteam経由でコントローラが操作されないように変更します。
   
   以下のレイアウトURLを利用するか、手動ですべての動作を「なし」（割り当ててない状態）に変更してください。変更したら設定およびSteamオーバーレイは閉じてください。
   
   `steam://controllerconfig/1618290/2908868527`
3. 「TRAIN CREW」の設定＞操作設定＞外部デバイス入出力が「有効」になっているかを確認してください。本ソフトウェアと通信する際に必要になります。
4. 「電車でGO!!専用ワンハンドルコントローラー for Nintendo Switch™」をコンピュータに接続し、本ソフトウェア(ZDG-TC.exe)を起動します。
5. 画面下のステータスが「準備完了」になっていれば、コントローラによる操作が可能になります。
   
   マスコンやボタンが動作しているかをご確認ください。なおボタンを押下している場合は、対応するラベルが赤くなります。
6. 「TRAIN CREW」の画面に戻り、通常通りダイヤを選択して、運転をお楽しみください。

   ダイヤを選択すると、本ソフトウェアのステータス部分に選択したダイヤと、速度が表示されるようになります。
   
   ※ダイヤを選択する際は、マウスやキーボードで操作してください。

# よくある質問(Q&A)

本ソフトウェアを使用するにあたり、寄せられるよくある質問を以下に掲載しています。
それでも解決しない場合は、GitHubのディスカッションなどでお寄せください。

**※Yuzulia及びYuzuRyo61(ゆずりょー)は公式のTwitterアカウントは所有しておりません。申し訳ありませんが、Twitter経由での質問はお受けすることはできません。**

## 「ゲームパッドが検出されませんでした。」と出る。
DirectInputによるゲームパッドが認識していないときに出ます。その場合はコントローラを接続し直したりして、メニューのファイル＞再検出をお選びいただくと、再度コントローラを検出します。複数接続している場合はゲームパッドのドロップダウンを選択して、該当するコントローラを選択してください。

## 設定は保存される？
本ソフトウェアを閉じる(終了する)際や、メニューから手動で保存することを選択したときに保存されます。

## 「電車でGO!!専用ワンハンドルコントローラー for Nintendo Switch™」以外のコントローラでも遊べる？
申し訳ありませんが、「電車でGO!!専用ワンハンドルコントローラー for Nintendo Switch™」以外のコントローラは動作保証外となっております。

## ZLボタンの設定が変更できないのはなぜ？
「電車でGO!!専用ワンハンドルコントローラー for Nintendo Switch™」のコントローラの仕様上、非常ブレーキの位置までマスコンを倒すと、ZLボタンが押下された状態になるからです。そのため、ZLボタンは予約済みとして変更することはできません。

## 「電車でGO!!専用ワンハンドルコントローラー for Nintendo Switch™」のマスコン位置をB8にしても反応しない。
「TRAIN CREW」のマスコンはB6(抑速を含めると7段階)までとなっておりますので、「電車でGO!!専用ワンハンドルコントローラー for Nintendo Switch™」のB8は「TRAIN CREW」のB6として扱っております。不具合ではありません。

## 「TRAIN CREW」のプレイを終えたのに、ステータス部分にダイヤが表示されたままになる。
「TRAIN CREW」との通信による仕様となっておりますので、不具合ではありません。

# 注記
このソフトウェアを開発するにあたり、acty(溝月レイル)から配布されている「コントローラ開発用キット（仮）」にある「TrainCrewInput.dll」を利用しています。
このdllはソフトウェアを再配布する場合に限り利用が可能となっており、本ソフトウェアのライセンスには当てはまらないことを留意の上、ご利用ください。

コントローラ開発用キット（仮）:
https://acty-soft.com/traincrew/controller/

# ライセンス
このソフトウェアはApache License 2.0で無料で配布、ソースコード公開をしています。
このライセンスに従う限り、自由に利用・改造することができます。
詳しい内容はソースコードにある「LICENSE」をご参照ください。

# 免責事項

本ソフトウェアは、Yuzulia / YuzuRyo61(ゆずりょー)は責任や保証を負わないものとします。本ソフトウェアのご利用は自己責任となりますことをご理解の上ご利用ください。

# 制作・著作

&copy; 2022 Yuzulia / YuzuRyo61 (ゆずりょー)

https://yuzulia.com/

https://yuzuryo61.me/

https://misskey.io/@YuzuRyo61

本ソフトウェアに関するご不明な点がございましたら、本ソフトウェアのGitHubディスカッションやDiscordサーバー「Yuzulia-Discord」、メール(時間を要する場合があります)で受け付けております。

Yuzulia-Discord(リンク先に招待リンクがあります): https://discord.yuzulia.com/

メール: `yuzuryo61@yuzulia.work`
