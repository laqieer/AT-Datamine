
TextBox = system.LinkUI("2D_Root/SafeArea/Container_TextBox", 400)
UiLoadList[#UiLoadList + 1] = TextBox

IsOpenTextBoxBase = false 

-- nowaitで再生したボイスシグナルなどを停止するため保持する
UITextBox_noWaitVoiceSignal = nil
UITextBox_noWaitLipsyncExecuter = nil
UITextBox_noWaitLipsyncForceEnd = false
Anime_Hide = "Hide"
Anime_Show = "Show"
UITextBox_bgHideStatus = Anime_Show

-- 初期化処理
function init_textbox()
	open_testbox_status_speech = false
	open_testbox_status_mind = false
	open_testbox_status_narration = false
	open_testbox_status_simple = false

	TextBox.SetActive(true)
	TextBox.SetActive("Speech", false)
	TextBox.SetActive("Mind", false)
	TextBox.SetActive("Talker", false)
	TextBox.SetActive("TalkerDemo", false)
	TextBox.SetActive("Text", false)
	TextBox.SetActive("CharacterL", false)
	TextBox.SetActive("CharacterR", false)
	SetLookonRegex("^(…|・)+$")
end

-- テキストボックスの入力検出オブジェクトアクティブを切り替える
function set_active_textbox_input_object(active)
	TextBox.SetActive("All", active)
end

function get_active_textbox_input_object()
	return TextBox.GetActive("All")
end

-- 黒帯を表示する
function open_textbox_base()
	UITextBox_hideStatus = "Show"
	if IsOpenTextBoxBase then
		return
	end
	IsOpenTextBoxBase = true
	local signal = TextBox.Play("In_02", true)

	-- 演出の終了待ち
	while signal.IsProccessing() do
		coroutine.yield()
	end
end

-- 黒帯を非表示にする
function close_textbox_base()
	TextBox.CancelInput("All")
	if not IsOpenTextBoxBase then
		return
	end
	IsOpenTextBoxBase = false
	local signal = TextBox.Play("Out_02", true)

	-- 演出の終了待ち
	while signal.IsProccessing() do
		coroutine.yield()
	end
end

-- 通常終了時と強制終了時に呼ばれる
function close_textbox_end()
	TextBox.CancelInput("All")
	signal = TextBox.Play("Init", true)
	while signal.IsProccessing() do
		coroutine.yield()
	end
end

-- ログWindowType定義
-- enum/textbox_type.xlsmと同値定義
ENUM_WinType_NULL = 0
ENUM_WinType_Speech = 1
ENUM_WinType_Mind = 2
ENUM_WinType_Narration = 3
ENUM_WinType_Simple = 4
ENUM_WinType_Choice = 5

-- 基本ウィンドウを開く(タイプで指定)
-- windowType = マスタEnum/WindowType.xlsmで定義したEnum
-- その他引数はopen_textboxと同様
function open_textbox_by_type(talkerNameTag, windowType, linkCharacterL, linkCharacterR, talkSpeed)
    
    if windowType == ENUM_WinType_Speech then
        open_speech_window(talkerNameTag, linkCharacterL, linkCharacterR, talkSpeed)
    end
    if windowType == ENUM_WinType_Mind then
        open_mind_window(talkerNameTag, linkCharacterL, linkCharacterR, talkSpeed)
    end
    if windowType == ENUM_WinType_Narration then
        open_narration_window()
    end
    if windowType == ENUM_WinType_Simple then
        open_simple_window(talkerNameTag)
    end
end

-- 基本ウィンドウを開く
--  talkerNameTag = 話者名のテキストのタグ
--  onSpeech = 通常用パーツの表示
--  onMind = 心の声用パーツの表示
--  onNarration = ナレーション用パーツの表示
--  onSimple = シンプル用パーツの表示
--  onLipsync = リップシンクする
--  linkCharacterL = 左側にリンクするキャラクターのコントローラID　※character2DでfacePrefabPath指定必須　いないならnil
--  linkCharacterR = 右側にリンクするキャラクターのコントローラID　※character2DでfacePrefabPath指定必須　いないならnil
--  talkSpeed = Dicingに送られる口パク速度
function open_textbox(talkerNameTag, onSpeech, onMind, onNarration, onSimple, onLipsync, linkCharacterL, linkCharacterR, talkSpeed)

	open_testbox_status = true

	--初期化（一旦全部非表示にする）
	TextBox.SetActive("Speech", false)
	TextBox.SetActive("Mind", false)
	TextBox.SetActive("Talker", false)
	TextBox.SetActive("TalkerSimple", false)
	TextBox.SetActive("Text", false)
	TextBox.SetActive("Mind_Center", false)
	TextBox.SetActive("Mind_Left", false)
	TextBox.SetActive("Mind_Right", false)

	
	local validTalker = (talkerNameTag != nil)
	-- 基本パーツの切り替え
	TextBox.SetActive("Speech", onSpeech)
	TextBox.SetActive("Mind", onMind)
	TextBox.SetActive("Mind_Center", onMind and linkCharacterL == nil and linkCharacterR == nil)
	TextBox.SetActive("Mind_Left", onMind and linkCharacterL != nil)
	TextBox.SetActive("Mind_Right", onMind and linkCharacterR != nil)
	TextBox.SetActive("Cursor", false)

	TextBox.SetActive("Text", true)

	set_name_tag(talkerNameTag, onSimple, validTalker)
	ActiveMessage = "Message"
	TextBox.SetText(ActiveMessage, "")
	-- キャラクターの画像
	local playList = {}
	ActiveTalkerL = linkCharacterL
	ActiveTalkerR = linkCharacterR
	ActiveTalker3d = nil
	ValidLipsync = onLipsync
	
	-- 口パク速度
	local speed
	if talkSpeed == nil then
		speed = -1.0
	else
		speed = talkSpeed
	end
	
	if ActiveTalkerL != nil then
		TextBox.SetActive("CharacterL", true)
		TextBox.AttachCharacterImage("CharacterL", ActiveTalkerL.FaceImageTag, FacialTags[ActiveTalkerL.ActiveFacialTag], ActiveTalkerL, ValidLipsync, speed)
		playList[#playList + 1] = "In_Chara"
	end
	if ActiveTalkerR != nil then
		TextBox.SetActive("CharacterR", true)
		TextBox.AttachCharacterImage("CharacterR", ActiveTalkerR.FaceImageTag, FacialTags[ActiveTalkerR.ActiveFacialTag], ActiveTalkerR, ValidLipsync, speed)
		playList[#playList + 1] = "In_Chara_R"
	end
	if ActiveTalkerL == nil and ActiveTalkerR == nil then
	end
	-- 開始演出
	playList[#playList + 1] = "In_01"
	TextBox.Play(true, playList)
	-- 背景の黒帯復帰
	in_bg()
	if validTalker then
		TextBox.StartTimeline("Root")
	end
	-- 開始演出の終了待ち
	while TextBox.IsProccessing() do
		coroutine.yield()
	end
	
end

-- ネームプレートの表示
-- talkerNameTag
-- onSimple シンプルならtrue
-- validTalker 表示ならtrue
function set_name_tag(talkerNameTag, onSimple, validTalker)
    local tagTalker = onSimple and "TalkerSimple" or "Talker"
    TextBox.SetActive(tagTalker, validTalker)
    if validTalker then
        TextBox.SetTextTag(tagTalker, talkerNameTag)
    end
    --　ログの話者名も変更
	set_advlog_talkertag(talkerNameTag)
end

-- 基本ウィンドウでメッセージ表示
--  inputText = テキストの入力
--  isTag = inputTextの内容　true:テキストタグ, false:本文文字列
--  validKeyWait = キー入力待ちをするか
--  voiceTag = ボイスタグ
function message_base(inputText, isTag, validKeyWait, voiceTag)
	local function message_character(active_talker)
		if active_talker != nil then
			lipsync(active_talker, "Talk")
			set_is_active_lipsync(active_talker, true)
		end
	end
	local function message_character_end(active_talker)
		if active_talker != nil then
			lipsync(active_talker, "Close")
			set_is_active_lipsync(active_talker, false)
		end
	end
	local function set_text(active_talker,text,time)
		if active_talker != nil then
			set_lipsync_text(active_talker, text,time)
		end
	end
	
	local function lockon_talker(active_talker)
		if active_talker != nil then
			local humanList = GetHumanList()
			for i,human in ipairs(humanList) do
				-- 話者以外の首を話者に向ける
				if active_talker.IsNo3DModel() == false and active_talker.GetName() != human.GetName() and human.GetEnableAutoLookAt() then
					-- weight設定がされてなければ注視設定した後でweightをかける
					if not human.GetIsSetWeight() then
						--初回設定時等weightが設定されていない場合は注視目標を設定したあとで
						human.KeepIkLookAt(active_talker, "J_Head", true)
						--weightの設定を行う。ここの順番を間違えると挙動が不自然になる
						lookat_delay_weight_default(human, 1)
						
					-- weight設定済みなら注視設定をする
					else
						--２回目以降はweightを変えたくない限りweightは変更不要
						human.KeepDelayIkLookAt(active_talker, "J_Head", 1, true)
					end
				end
			end
		end
	end

	local function exec_lipsync(ValidLipsync, voiceSignal, soundSignal, timeSignal)
		local isVoice = (voiceSignal != nil and soundSignal != nil)
		local isTimer = (timeSignal != nil)
		-- 口パクが必要なセリフ
		if ValidLipsync then
			-- ボイス有の判定
			if isVoice then
				-- ボイスの終了判定
				if voiceSignal.IsProccessing() then
				-- 口パクシグナル基準で口を閉じる
					if soundSignal.IsVolumeMute() then
						message_character_end(ActiveTalkerL)
						message_character_end(ActiveTalkerR)
						message_character_end(ActiveTalker3d)
					else
						message_character(ActiveTalkerL)
						message_character(ActiveTalkerR)
						message_character(ActiveTalker3d)
					end
				else
					message_character_end(ActiveTalkerL)
					message_character_end(ActiveTalkerR)
					message_character_end(ActiveTalker3d)
				end
			-- 口パク継続時間の判定
			elseif isTimer then
				if timeSignal.IsProccessing() then 
					message_character(ActiveTalkerL)
					message_character(ActiveTalkerR)
					message_character(ActiveTalker3d)
				else
					message_character_end(ActiveTalkerL)
					message_character_end(ActiveTalkerR)
					message_character_end(ActiveTalker3d)
				end
			end
		end
		return ((voiceSignal == nil or not voiceSignal.IsProccessing()) and (timeSignal == nil or not timeSignal.IsProccessing()))
	end

	
	if isTag == nil then
		isTag = true
	end
	if ActiveTalkerL != nil then
		TextBox.ChangeCharacterFacial("CharacterL", FacialTags[ActiveTalkerL.ActiveFacialTag])
	end
	if ActiveTalkerR != nil then
		TextBox.ChangeCharacterFacial("CharacterR", FacialTags[ActiveTalkerR.ActiveFacialTag])
	end
	local textList;
	if isTag then
		textList = TextBox.GetTexts(inputText)
	else
		textList = { inputText }
	end
	
	local voiceSignal = nil
	local soundSignal = nil
	-- ボイスがあったらボイス再生をしてシグナルを受け取る
	if voiceTag != nil then
		voiceSignal = voice_play(voiceTag)
		soundSignal = get_sound(voiceSignal)
	end

	for i,textLine in ipairs(textList) do
		local timeSignal = nil
		local lipFinished = false
		-- 口パク有効で注視対象外文字じゃなければ注視処理
		if ValidLipsync and not IsMatchLookonRegex(textLine) then
			lockon_talker(ActiveTalkerL)
			lockon_talker(ActiveTalkerR)
			lockon_talker(ActiveTalker3d)
		end	
		--STAQDEV-13551 口パク終了時に1秒の余韻を発生させる 
		local afterglowDuration = 1.0
		
		--常にテキスト換算の秒数は計算する
		local lip_seconds = #textLine * 0.1 -- 仮に１文字0.1秒（文字の内容は無視）
		
		-- STAQDEV-10848 最短１秒、最長３秒の設定
		if(lip_seconds < 1) then
			lip_seconds = 1
		elseif (lip_seconds > 3) then
			lip_seconds = 3
		end
		
		timeSignal = system.CreateTimer(lip_seconds)
		set_text(ActiveTalkerL,textLine,lip_seconds)
		set_text(ActiveTalkerR,textLine,lip_seconds)
		set_text(ActiveTalker,textLine,lip_seconds)
		

		--STAQDEV-13551 口パク終了時に1秒の余韻を発生させる 
		local afterglowDuration = 1.0
		
		--常にテキスト換算の秒数は計算する
		local lip_seconds = #textLine * 0.1 -- 仮に１文字0.1秒（文字の内容は無視）
	

		TextBox.SetActive("Cursor", true)
		-- テキスト表示
		TextBox.SetMessage(ActiveMessage, textLine, "All")
		
		-- ログ用にテキスト登録。ボイスも一緒に登録。
		add_advlog_message(textLine, voiceTag)
		
		if system.GetPlayMode() >= 0 then
			
			-- 入力待ち
			if validKeyWait then
				TextBox.SetActive("All", true)
				TextBox.Input("All")
			end

			while TextBox.IsProccessing() do
				local wait_end = exec_lipsync(ValidLipsync, voiceSignal, soundSignal, timeSignal)
				
				--ボイス再生も継続時間も終わった
				if (not lipFinished and wait_end) then
					lipFinished = true
					afterglowSignal = system.CreateTimer(afterglowDuration)
				end
				
				coroutine.yield()
				
				if system.IsAdvLogMode() == true then
					-- ADVログモード中は自動進行もスキップもしない
				elseif system.GetPlayMode() < 0 or system.GetPlaySpeed() != 1 then
					-- スキップ
					TextBox.CancelInput("All")
					break
				elseif system.GetPlayMode() > 0 and (lipFinished and not afterglowSignal.IsProccessing()) then
					-- 自動進行
					TextBox.CancelInput("All")
					break
				end
			end
			if system.GetPlayMode() >= 0 then
				system.PlaySE("SE_00009")
			end
			
			-- 文字順次送り中なら
			if TextBox.IsOneCharacterProcess(ActiveMessage) then
				
				-- 文字全部表示
				TextBox.DrawMessageAll(ActiveMessage)
			
				-- 再度入力待ち
				if validKeyWait then
					TextBox.Input("All")
				end
				
				while TextBox.IsProccessing() do
					local wait_end = exec_lipsync(ValidLipsync, voiceSignal, soundSignal, timeSignal)

					--ボイス再生も継続時間も終わった
					if (not lipFinished and wait_end) then
						lipFinished = true
						afterglowSignal = system.CreateTimer(afterglowDuration)
					end

					if system.IsAdvLogMode() == true then
						-- ADVログモード中は自動進行もスキップもしない
					elseif system.GetPlayMode() < 0 or system.GetPlaySpeed() != 1 then
						-- スキップ
						TextBox.CancelInput("All")
						break
					elseif system.GetPlayMode() > 0 and (lipFinished and not afterglowSignal.IsProccessing()) then
						-- 自動進行
						TextBox.CancelInput("All")
						break
					end
					coroutine.yield()
				end
			end
		end

		if validKeyWait then
			-- 口パクが終わってなかったら終了
			if not lipFinished then
				message_character_end(ActiveTalkerL)
				message_character_end(ActiveTalkerR)
				message_character_end(ActiveTalker3d)
			end
		
			-- ボイスがあったら終了しておく
			if voiceSignal != nil then
				voice_stop(voiceSignal)
			end
		else
			UITextBox_noWaitVoiceSignal = voiceSignal
			if ValidLipsync then
				UITextBox_noWaitLipsyncExecuter = create_coroutine(no_wait_lipsync_executer)
				isVoice = (voiceSignal != nil and soundSignal != nil)
				isTimer = (timeSignal != nil)
				UITextBox_noWaitLipsyncForceEnd = false
				coroutine.resume(UITextBox_noWaitLipsyncExecuter, isVoice, voiceSignal, soundSignal, isTimer, timeSignal)
			end
		end
	end
	TextBox.SetActive("Cursor", false)
end

function no_wait_lipsync_executer(is_voice, voice_signal, sound_signal, is_timer, time_signal)
	local function message_character(active_talker)
		if active_talker != nil then
			lipsync(active_talker, "Talk")
			set_is_active_lipsync(active_talker, true)
		end
	end
	local function message_character_end(active_talker)
		if active_talker != nil then
			lipsync(active_talker, "Close")
			set_is_active_lipsync(active_talker, false)
		end
	end
	local play_lipsync = true
	while play_lipsync do
		-- ボイス有の判定
		if is_voice then
			-- ボイスの終了判定
			if voice_signal.IsProccessing() then
				-- 口パクシグナル基準で口を閉じる
				if sound_signal.IsVolumeMute() then
					message_character_end(ActiveTalkerL)
					message_character_end(ActiveTalkerR)
					message_character_end(ActiveTalker3d)
				else
					message_character(ActiveTalkerL)
					message_character(ActiveTalkerR)
					message_character(ActiveTalker3d)
				end
			else
				message_character_end(ActiveTalkerL)
				message_character_end(ActiveTalkerR)
				message_character_end(ActiveTalker3d)
				play_lipsync = false
			end
		-- 口パク継続時間の判定
		elseif is_timer then
			if time_signal.IsProccessing() then 
				message_character(ActiveTalkerL)
				message_character(ActiveTalkerR)
				message_character(ActiveTalker3d)
			else
				message_character_end(ActiveTalkerL)
				message_character_end(ActiveTalkerR)
				message_character_end(ActiveTalker3d)
				play_lipsync = false
			end
		else
			message_character_end(ActiveTalkerL)
			message_character_end(ActiveTalkerR)
			message_character_end(ActiveTalker3d)
			play_lipsync = false
		end
		coroutine.yield()

		if UITextBox_noWaitLipsyncForceEnd then
			return
		end
	end
end

function stop_nowait_message_voice_and_lipsync()
	local function message_character_end(active_talker)
		if active_talker != nil then
			lipsync(active_talker, "Close")
			set_is_active_lipsync(active_talker, false)
		end
	end

	if UITextBox_noWaitVoiceSignal != nil then
		voice_stop(UITextBox_noWaitVoiceSignal)
		UITextBox_noWaitVoiceSignal = nil
	end
	if UITextBox_noWaitLipsyncExecuter ~= nil then
		if coroutine.status(UITextBox_noWaitLipsyncExecuter) ~= "dead" then
			UITextBox_noWaitLipsyncForceEnd = true
			message_character_end(ActiveTalkerL)
			message_character_end(ActiveTalkerR)
			message_character_end(ActiveTalker3d)
		end
		UITextBox_noWaitLipsyncExecuter = nil
	end
end

-- 基本ウィンドウでメッセージ表示
--  messageTag = メッセージのタグ
function message(messageTag)
	PlayBranchPoint(messageTag)
	local voiceTag = system.GetVoiceTag(messageTag)
	message_base(messageTag, true, true, voiceTag)
	EndBranchPoint()
end

-- 基本ウィンドウでメッセージ表示
--  messageText = メッセージ文
function message_direct(messageText)
	message_base(messageText, false, true, nil)
end

-- 基本ウィンドウでメッセージ表示（キー入力待ち無し）
--  messageTag = メッセージのタグ
function message_nowait(messageTag)
	PlayBranchPoint(messageTag)
	local voiceTag = system.GetVoiceTag(messageTag)
	message_base(messageTag, true, false, voiceTag)
	EndBranchPoint()
end

-- 基本ウィンドウでメッセージ表示（キー入力待ち無し）
--  messageText = メッセージ文
function message_direct_nowait(messageText)
	message_base(messageText, false, false, nil)
end


-- 基本ウィンドウでメッセージ表示
--  voiceTag = ボイスのタグ
--  messageTag = メッセージのタグ
function v_message(voiceTag, messageTag)
	message_base(messageTag, true, true, voiceTag)
end

-- 基本ウィンドウでメッセージ表示
--  voiceTag = ボイスのタグ
--  messageText = メッセージ文
function v_message_direct(voiceTag, messageText)
	message_base(messageText, false, true, voiceTag)
end

-- 基本ウィンドウでメッセージ表示（キー入力待ち無し）
--  voiceTag = ボイスのタグ
--  messageTag = メッセージのタグ
function v_message_nowait(voiceTag, messageTag)
	message_base(messageTag, true, false, voiceTag)
end

-- 基本ウィンドウでメッセージ表示（キー入力待ち無し）
--  voiceTag = ボイスのタグ
--  messageText = メッセージ文
function v_message_direct_nowait(voiceTag, messageText)
	message_base(messageText, false, false, voiceTag)
end

-- メッセージ中に埋め込まれている<%1>や<%2>等を置換して表示(直接テキスト指定版)
--  messageText = メッセージ文
-- それ以降の引数は、置き換える文字列
function message_replace_direct(messageText, ...)
    local n = {...}
    for i = 1, #n do
        local pat = string.format("<%%%%%d>", i)
	    messageText = string.gsub(messageText, pat, n[i])
    end
    message_base(messageText, false, true, nil, nil)
	
end

-- メッセージ中に埋め込まれている<%1>や<%2>等を置換して表示
--  messageTag = メッセージのタグ
-- それ以降の引数は、置き換える文字列
function message_replace(messageTag, ...)
    local n = {...}
    local messageText = get_message_text(messageTag)
    for i = 1, #n do
        local pat = string.format("<%%%%%d>", i)
	    messageText = string.gsub(messageText, pat, n[i])
    end
    message_base(messageText, false, true, nil, nil)
end


-- メッセージ中に埋め込まれている<%1>や<%2>等を置換して表示(直接テキスト指定版)
--  voiceTag = ボイスのタグ
--  messageText = メッセージ文
-- それ以降の引数は、置き換える文字列
function v_message_replace_direct(voiceTag, messageText, ...)
    local n = {...}
    for i = 1, #n do
        local pat = string.format("<%%%%%d>", i)
	    messageText = string.gsub(messageText, pat, n[i])
    end
    message_base(messageText, false, true, nil, voiceTag)
	
end

-- メッセージ中に埋め込まれている<%1>や<%2>等を置換して表示
--  voiceTag = ボイスのタグ
--  messageTag = メッセージのタグ
-- それ以降の引数は、置き換える文字列
function v_message_replace(voiceTag, messageTag, ...)
    local n = {...}
    local messageText = get_message_text(messageTag)
    for i = 1, #n do
        local pat = string.format("<%%%%%d>", i)
	    messageText = string.gsub(messageText, pat, n[i])
    end
    message_base(messageText, false, true, nil, voiceTag)
end


-- 基本ウィンドウを閉じる
--  onSpeech = 通常用パーツの表示
--  onMind = 心の声用パーツの表示
--  onNarration = ナレーション用パーツの表示
--  onSimple = シンプル用パーツの表示
function close_textbox(onSpeech, onMind, onNarration, onSimple)
	local function close_character(active_talker)
		if active_talker != nil then
			animator_default_motion_if_need(active_talker)
			lipsync(active_talker, "Close")
		end
	end
	local function finished_character(active_talker)
		if active_talker != nil then
			active_talker.ActionBlink = nil
			active_talker.ActionLipsync = nil
		end
	end

	close_character(ActiveTalkerL)
	close_character(ActiveTalkerR)

	local playList = {}
	playList[#playList + 1] = "Out_01"
	if ActiveTalkerL != nil then
		playList[#playList + 1] = "Out_Chara"
	end
	if ActiveTalkerR != nil then
		playList[#playList + 1] = "Out_Chara_R"
	end
	TextBox.Play(true, playList)
	while TextBox.IsProccessing() do
		coroutine.yield()
	end

	finished_character(ActiveTalkerL)
	finished_character(ActiveTalkerR)
	ActiveTalkerL = nil
	ActiveTalkerR = nil
	ActiveTalker3d = nil

	open_testbox_status = false
end

-- 通常ウィンドウを開く
--  talkerNameTag = 話者名のテキストのタグ
--  linkCharacterL = 左側にリンクするキャラクターのコントローラID　※character2DでfacePrefabPath指定必須　いないならnil
--  linkCharacterR = 右側にリンクするキャラクターのコントローラID　※character2DでfacePrefabPath指定必須　いないならnil
--  talkSpeed = Dicingに送られる口パク速度
function open_speech_window(talkerNameTag, linkCharacterL, linkCharacterR, talkSpeed)
	open_textbox(talkerNameTag, true, false, false, false, true, linkCharacterL, linkCharacterR, talkSpeed)
	
	-- ログ用に開いたWindowをセット
	set_advlog_window(ENUM_AdvLogWinType_Speech, talkerNameTag, linkCharacterL, linkCharacterR)
end

-- 通常ウィンドウを開く(2D表示がなく3Dのみ口パクを行いたい場合こちらで口パク対応モデルの設定をしてもらう必要がある
--  talkerNameTag = 話者名のテキストのタグ
--  character = 口パクさせたい3Dモデル
--  talkSpeed = Dicingに送られる口パク速度
function open_speech_window_only3d(talkerNameTag, character, talkSpeed)
	open_textbox(talkerNameTag, true, false, false, false, true, nil, nil, talkSpeed)
	ActiveTalker3d = character
	
	-- ログ用に開いたWindowをセット
	set_advlog_window(ENUM_AdvLogWinType_Speech, talkerNameTag, linkCharacterL, linkCharacterR)
end

-- 心の声ウィンドウを開く
--  talkerNameTag = 話者名のテキストのタグ
--  linkCharacterL = 左側にリンクするキャラクターのコントローラID　※character2DでfacePrefabPath指定必須　いないならnil
--  linkCharacterR = 右側にリンクするキャラクターのコントローラID　※character2DでfacePrefabPath指定必須　いないならnil
--  talkSpeed = Dicingに送られる口パク速度
function open_mind_window(talkerNameTag, linkCharacterL, linkCharacterR, talkSpeed)
	open_textbox(talkerNameTag, false, true, false, false, false, linkCharacterL, linkCharacterR, talkSpeed)
	
	-- ログ用に開いたWindowをセット
	set_advlog_window(ENUM_AdvLogWinType_Mind, talkerNameTag, linkCharacterL, linkCharacterR)
end

-- 心の声2 枠は心の声と同じだが口パクする
function open_mind_talk_window(talkerNameTag, linkCharacterL, linkCharacterR, talkSpeed)
	open_textbox(talkerNameTag, false, true, false, false, true, linkCharacterL, linkCharacterR, talkSpeed)
	
	-- ログ用に開いたWindowをセット
	set_advlog_window(ENUM_AdvLogWinType_Mind, talkerNameTag, linkCharacterL, linkCharacterR)
end

-- ナレーションウィンドウを開く
function open_narration_window()
	open_textbox(nil, false, false, true, false, true, nil, nil)
	
	-- ログ用に開いたWindowをセット
	set_advlog_window(ENUM_AdvLogWinType_Narration, nil, nil, nil)
end

-- シンプルウィンドウを開く
--  talkerNameTag = 話者名のテキストのタグ
function open_simple_window(talkerNameTag)
	open_textbox(talkerNameTag, false, false, false, true, true, nil, nil)

	-- ログ用に開いたWindowをセット
	set_advlog_window(ENUM_AdvLogWinType_Simple, talkerNameTag, nil, nil)
end

-- シンプルウィンドウを開く
--  talkerNameTag = 話者名のテキストのタグ
function open_simple_window_only3d(talkerNameTag, character)
	open_textbox(talkerNameTag, false, false, false, true, true, nil, nil)
	
	ActiveTalker3d = character
	
	-- ログ用に開いたWindowをセット
	set_advlog_window(ENUM_AdvLogWinType_Simple, talkerNameTag, nil, nil)
end

-- 通常ウィンドウを閉じる
function close_speech_window()
	close_textbox(true, false, false, false)
	
	-- ログ用Windowを閉じる
	close_advlog_window()
end

-- 心の声ウィンドウを閉じる
function close_mind_window()
	close_textbox(false, true, false, false)

	-- ログ用Windowを閉じる
	close_advlog_window()
end

-- 心の声2ウィンドウを閉じる
function close_mind_talk_window()
	close_textbox(false, true, false, false)

	-- ログ用Windowを閉じる
	close_advlog_window()
end

-- ナレーションウィンドウを閉じる
function close_narration_window()
	close_textbox(false, false, true, false)

	-- ログ用Windowを閉じる
	close_advlog_window()
end

-- シンプルウィンドウを閉じる
function close_simple_window()
	close_textbox(false, false, false, true)

	-- ログ用Windowを閉じる
	close_advlog_window()
end

-- 
function hide_ui_textbox()
	local anime = Anime_Hide
	if ActiveTalkerL != nil and ActiveTalkerR != nil then
		anime = "HideWithTalkerLAndR"
	elseif ActiveTalkerL != nil then
		anime = "HideWithTalkerL"
	elseif ActiveTalkerR != nil then
		anime = "HideWithTalkerR"
	end
	TextBox.Play(anime, false)
	UITextBox_bgHideStatus = Anime_Hide
end

function show_ui_textbox()
	if UITextBox_bgHideStatus ~= Anime_Show then
		local anime = "Show"
		if ActiveTalkerL != nil and ActiveTalkerR != nil then
			anime = "ShowWithTalkerLAndR"
		elseif ActiveTalkerL != nil then
			anime = "ShowWithTalkerL"
		elseif ActiveTalkerR != nil then
			anime = "ShowWithTalkerR"
		end
		TextBox.Play(anime, true)
		UITextBox_bgHideStatus = Anime_Show
	end
end

-- テキストの後ろの黒い帯を復帰させる
function in_bg()
	if UITextBox_bgHideStatus ~= "Show" then
		TextBox.Play("In_BG", true)
		UITextBox_bgHideStatus = "Show"
	end
end

-- ホームボタンからホームに戻るとき消える
function if_opened_hide_ui_textbox()
	if open_testbox_status == true then
		hide_ui_textbox()

		open_testbox_status = false
	end
end
