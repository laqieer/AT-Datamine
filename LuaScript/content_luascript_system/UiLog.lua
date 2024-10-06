--[[
	Advのログを保存する処理
]]


-- ログ初期化。最初にログUIパーツを作っておく
function init_adv_log()
	-- 表示されているWindowの種類判定用
	AdvLogWindow = 0
	
	-- 表示されるキャラサムネイル画像
	AdvLogThumbImageTag = nil
	
	-- ログWindowType定義
	ENUM_AdvLogWinType_NULL = 0
	ENUM_AdvLogWinType_Speech = 1
	ENUM_AdvLogWinType_Mind = 2
	ENUM_AdvLogWinType_Narration = 3
	ENUM_AdvLogWinType_Simple = 4
	ENUM_AdvLogWinType_Choice = 5
	
	
	-- ログを開く前の倍速状態を取っておく用
	isDefaultSpeed = false
end


-- ADVのログを開く
function open_adv_log()
	debug_print("open_adv_log")
	
	-- footerの他ボタンは操作をさせない ≠ 機能をoffにする  
	SetFooterButtonInteractableInAdvLog(false)

	LogUI.SetButtonFunction("CloseButton", onClickButtonLogClose, true)

	system.AdvOpenLog(true)
end

-- ADVのログを閉じる
function close_adv_log()
	debug_print("close_adv_log")
	
	system.AdvOpenLog(false)

	-- footerの他ボタンは操作を復帰  
	SetFooterButtonInteractableInAdvLog(true)

end


-- 選択肢ログ追加だけはメッセージログ表示時に出てしまうので特殊処理
-- message = 選択肢メッセージ
-- Chara = キャラクターのタグ
function add_advchoicelog(message, Chara)
	-- debug_print("add_advchoicelog")
	if isOpenFooter == false then
		return
	end
	
	local ThumbImageTag = nil
	
	if Chara != nil then
		if Chara.ThumbImageTag != nil then
			ThumbImageTag = Chara.ThumbImageTag
		end
	end
	
	-- ログを追加
	system.AddLog(ENUM_AdvLogWinType_Choice, nil, ThumbImageTag, message, nil)
end


-- メッセージと共にログを追加する
function add_advlog_message(message, voice)
	-- debug_print("add_advlog_message")
	if isOpenFooter == false then
		return
	end
	
	local list = {}
	
	--通常と心の声とシンプルWindowの時だけ、話者名と顔イラストを有効にする
	if AdvLogWindow == ENUM_AdvLogWinType_Speech or AdvLogWindow == ENUM_AdvLogWinType_Mind or AdvLogWindow == ENUM_AdvLogWinType_Simple then
		list.wintype = AdvLogWindow
		list.talker = AdvLogTalkerTag
		list.image = AdvLogThumbImageTag
		list.message = message
		list.voice = voice
	else
		list.wintype = AdvLogWindow
		list.message = message
		list.talker = nil
		list.image = nil
		list.voice = voice
	end
	
	-- ログを追加
	system.AddLog(list.wintype, list.talker, list.image, list.message, list.voice)
end

-- 話者名の切り替え用
function set_advlog_talkertag(talker)
 AdvLogTalkerTag = talker
end

-- 開いたWindowタイプとキャラを保存
function set_advlog_window(WinType, TalkerTag, CharaL, CharaR)
	-- debug_print("set_advlog_window")
	if isOpenFooter == false then
		return
	end
	AdvLogWindow = WinType
	
	-- 話者名タグを登録
	AdvLogTalkerTag = TalkerTag
	
	-- キャラ画像のサムネイルタグを登録
	if CharaL != nil then
		if CharaL.ThumbImageTag != nil then
			AdvLogThumbImageTag = CharaL.ThumbImageTag
		else
			AdvLogThumbImageTag = nil
		end
	elseif CharaR != nil then
		if CharaR.ThumbImageTag != nil then
			AdvLogThumbImageTag = CharaR.ThumbImageTag
		else
			AdvLogThumbImageTag = nil
		end
	else
		AdvLogThumbImageTag = nil
	end
end


-- Windowを閉じる
function close_advlog_window()
	-- debug_print("close_advlog_window")
	if isOpenFooter == false then
		return
	end
	AdvLogWindow = ENUM_AdvLogWinType_NULL
	AdvLogTalkerTag = nil
	AdvLogThumbImageTag = nil
end
