Include("content_luascript_system", "LuaCommonPack")

-- アセットなどを読み込む
function Load()
	Load_common(true)
	load_scene("content_areascene_110011", "Area110011") -- 教室
	Camera01 = set_camera(-2.74, 1.531, 1.382, 0.0, 0.0, 0.0, 60)
	set_camera_lookat(Camera01, 0.0, 1.01, -5.15)
end

-- シーケンスの実行
function Play()
	on_camera(Camera01)
	fadein(0)
	Play_start(true)

	auto_select(1) -- adv_option「アイテム選択テスト：開始」

	-- 単種アイテムを選択するテスト
	open_narration_window()
	message_direct("単種アイテム選択テスト")
	local selected_order = open_item_window() -- adv_option「アイテム選択テスト：使用選択」
	if selected_order == 1 then
		message_direct("傷薬を選びました")
	elseif selected_order == 2 then
		message_direct("高級傷薬を選びました")
	elseif selected_order == 3 then
		message_direct("ゼニーを選びました")
	elseif selected_order == 4 then
		message_direct("１章コインを選びました")
	elseif selected_order == 5 then
		message_direct("ギルドコインを選びました")
	elseif selected_order == 6 then
		message_direct("小金塊を選びました")
	elseif selected_order == 7 then
		message_direct("中金塊を選びました")
	elseif selected_order == 8 then
		message_direct("大金塊を選びました")
	else
		message_direct("選びませんでした")
	end
	close_narration_window()

	-- パラメータ変更を含むテスト
	open_narration_window()
	message_direct("パラメータ変更を含むテスト")
	message_direct("テストパラメータの初期値を設定します")
	open_select_window(nil, nil) -- adv_option「アイテム選択テスト：パラメータ初期値」
	message_direct("所持アイテムを選択します")
	open_select_window(nil, nil) -- adv_option「アイテム選択テスト：効率アイテム初期値」
	message_direct("効率アイテムを選択します")
	local selected_order = open_item_window() -- adv_option「アイテム選択テスト：効率アイテム選択」
	if selected_order <= 3 then
		message_direct("アイテムを使ってパラメータを上げます")
	else
		message_direct("パラメータを上げます")
	end
	close_narration_window()

	local value_before = system.Param.GetInt("１章：優しさ")
	auto_select(1) -- adv_option「アイテム選択テスト：実行」
	local value_after = system.Param.GetInt("１章：優しさ")
	debug_print(value_before .. "->" .. value_after)

	open_trust_gauge(1)

	open_parameter_up()

	Play_end(true)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_scene_preload("content_areascene_110011", "Area110011")
end
