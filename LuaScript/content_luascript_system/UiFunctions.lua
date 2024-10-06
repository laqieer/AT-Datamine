--[[
	UIの処理
]]

UiLoadList = {}
UiIdlingList = {}

-- UIデザイナーから、Timelineアセットが単独で来るのでまとめてロード待ちする
UiAssetLoadList = {}

-- UIをロードする
function load_ui()
	-- 単独アセットのロード
	for index, asset in pairs(UiAssetLoadList) do
		while asset.IsProccessing() do
			coroutine.yield()
		end
	end
	
	-- プレハブのロード
	for index, ui in pairs(UiLoadList) do
		while ui.IsProccessing() do
			coroutine.yield()
		end
		ui.SetActive(false)
	end
	UiLoadList = {}
	-- １フレーム動かさないといけないコンポーネントを持ったのがいるので
	for index, ui in pairs(UiIdlingList) do
		ui.SetActive(true)
	end
	coroutine.yield()
	for index, ui in pairs(UiIdlingList) do
		ui.SetActive(false)
	end
	UiIdlingList = {}
	-- 表情タグの3D->2D変換テーブル
	FacialTags = {}
	FacialTags["Normal"]	= "Usual"		-- 通常
	FacialTags["Sad"]		= "Sad"			-- 哀しい
	FacialTags["Smile"]		= "Happy"		-- 笑顔
	FacialTags["Anger"]		= "Angry"		-- 怒り
	FacialTags["Pain"]		= "Pain"		-- 痛み
	FacialTags["Surprise"]	= "Surprise"	-- 驚く
	FacialTags["Serious"]	= "Serious"		-- 真剣
	FacialTags["Shy"]		= "Shy"			-- 照れる
	FacialTags["Special"]		= "Special"			-- 特殊
	FacialTags["Laugh"]		= "Laugh"		-- 微笑
		
	-- Hierarchyの並び順を変えて描画順調整
	if Image_2DBackCanvas != nil then
		-- safeエリアから外すように2D_Rootの階層に変える
		Image_2DBackCanvas.ChangeParentBack2dRoot()
		-- 表示位置を最奥にする
		Image_2DBackCanvas.SetAsFirstSibling()
	end
	if Image_2DCanvas != nil then
		-- safeエリアから外すように2D_Rootの階層に変える
		Image_2DCanvas.ChangeParent2dRoot()
		-- 表示位置を最奥にする
		Image_2DCanvas.SetAsFirstSibling()
	end
	
	if SkipUI != nil then
		-- 倍速再生エフェクト
		SkipUI.SetAsLastSibling()
	end
	if LogUI != nil then
		-- ログUI
		LogUI.SetAsLastSibling()
		
		-- ログUIは、スクロールバーが非アクティブだと機能しないので、アルファ値でONOFF制御する
		LogUI.SetActive(true)
	end
	if FooterUI != nil then
		-- フッターボタン類
		FooterUI.SetAsLastSibling()
	end	

	if TextBox != nil then
		-- テキストボックスの初期表示状態の設定
		init_textbox()
	end
end

-- Play前にシステムから自動で呼ばれる
function start_ui_proc()
	if AUTO_DEMO_PLAY != nill and AUTO_DEMO_PLAY then
		if FooterUI != nil then
			FooterUI.Play("Hide", false)
		end
		if TextBox != nil then
			TextBox.Play("HideTextbox", true)
			TextBox.SetActive("All", false)
		end

		-- auto再生をする
		system.SetPlayMode(1)
		system.SetPlaySpeed(1.0)
	end
	if disableTextBox != nil and disableTextBox == true then
		return
	end
	if TextBox != nil then
		-- テキストボックスの表示
		open_textbox_base()
	end
end

-- Play後にシステムから自動で呼ばれる
function end_ui_proc()
	if TextBox != nil then
		-- テキストボックスの表示
		close_textbox_end()
	end

	if AUTO_DEMO_PLAY != nill and AUTO_DEMO_PLAY then
		if FooterUI != nil then
			FooterUI.Play("Show", false)
		end
		if TextBox != nil then
			TextBox.Play("ShowTextbox", true)
			TextBox.SetActive("All", true)
		end
	end
end

-- 選択肢をスクリプトが自動指定する
--  index = 選びたい選択肢の番号（1～）
function auto_select(index)
	system.SetSelectedKey(index)
end

-- 画面全体のフェードイン
--  duration = 時間
function fadein(duration)
	system.FadeIn(duration)
end

-- 画面全体のフェードアウト
--  r = 最終的な画面の色の要素（R）
--  g = 最終的な画面の色の要素（G）
--  b = 最終的な画面の色の要素（B）
--  a = 最終的な画面の色の要素（A）
--  duration = 時間
function fadeout(r, g, b, a, duration)
	if type(r) == "table" then
		system.FadeOut(r[1], r[2], r[3], r[4], r[5])
	else
		system.FadeOut(r, g, b, a, duration)
	end
end

-- 画面全体のトランジションOUT演出
function transitionout()
	system.TransitionOut()
end

-- 画面全体のトランジションIN演出
function transitionin()
	system.TransitionIn();
end

-- 日付In
function dateIn()
	system.DateIn()
end

-- 日付Out
function dateOut()
	system.DateOut()
end

