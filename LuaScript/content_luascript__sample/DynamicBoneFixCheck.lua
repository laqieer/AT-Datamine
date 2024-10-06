-- β2テスト/MA_01104_10【4-10入学試験】 -----------------------------------------------------------------------

Include("content_luascript_system", "LuaCommonPack")
Include("content_luascript_common", "DemoCommonPack")
Include("content_luascript_common", "SceneCommonPack")
Include("content_luascript_story_beta3", "MA_01104_10_h")

-- アセットなどを読み込む
function Load()
	demo_setup()
	load_area_scene(110051) -- 円卓の間

-- 画像の読み込み
	load_image("MA011041001", "content_image_beta3_ma0110410", "MA011041001")
	load_image("MA011041002", "content_image_beta3_ma0110410", "MA011041002")

-- ------------------------------------------
-- 初期配置
	setup_Noir(No_01_000004_1)
	setup_Dinatan(Di_01_000004_1)
	setup_101015_Arthur(At_01_000004_1, "Arthur_EntakuSit_loop", 0, true)
	setup_Kay(Ky_01_000004_1) --ケイダミー
	setup_Lancelot(La_01_000004_0)
	setup_Guinevere(Gu_01_000004_0)
	setup_Gwenhwymawr(Gw_01_000004_0) --ギネマウアダミー

	Chair_gold = get_object("geo_chair_gold") -- アーサーの椅子
	set_pos(Chair_gold, Chair_gold_pos)


----キャラの初期モーション（セット方法を変えた時のため）
	motion(Noir,"Sri_Std_loop_m", 0.3,1.0, true)
	motion(Dinatan,"Bea_Std02_Loop_f", 0.3,1.0, true)
	motion(Kay,"Col_Std_loop_m", 0.3,1.0, true)
	motion(Lancelot,"Col_Std_loop_m", 0.3,1.0, true)
	motion(Guinevere,"Nbl_Std_loop_f", 0.3,1.0, true)
	motion(Gwenhwymawr,"Bea_Std02_Loop_f", 0.3,1.0, true)

-- ------------------------------------------

-- ------------------------------------------
-- カメラ設定
	CUT_CAMERA1	= set_camera(Camera_01_0410_1)	-- ケイアップ
	CUT_CAMERA2	= set_camera(Camera_01_0410_2)	-- ノワール、ディナタン
	CUT_CAMERA3	= set_camera(Camera_01_0410_3)	-- アーサー登場
	CUT_CAMERA4	= set_camera(Camera_01_0410_4)	-- アーサー視点のケイ
	CUT_CAMERA5	= set_camera(Camera_01_0410_5)	-- アーサー
	CUT_CAMERA6	= set_camera(Camera_01_0410_6)	-- アーサー、ケイ
	CUT_CAMERA8	= set_camera(Camera_01_0410_8)	-- アーサー、手前
	CUT_CAMERA9	= set_camera(Camera_01_0410_9)	-- 剣の祭壇
	CUT_CAMERA10	= set_camera(Camera_01_0410_10)	-- ノワール横顔
	CUT_CAMERA11	= set_camera(Camera_01_0410_11)	-- アーサー、ケイ
	CUT_CAMERA12	= set_camera(Camera_01_0410_12)	-- ランスロットアップ
	CUT_CAMERA12_2	= set_camera(Camera_01_0410_12_2)	-- ランスロット歩いてくる
	CUT_CAMERA13	= set_camera(Camera_01_0410_13)	-- ケイ振り向く
	CUT_CAMERA14	= set_camera(Camera_01_0410_14)	-- ランスロット手前
	CUT_CAMERA15	= set_camera(Camera_01_0410_15)	-- ノワール
	CUT_CAMERA16	= set_camera(Camera_01_0410_16)	-- アーサー思案
	CUT_CAMERA17	= set_camera(Camera_01_0410_17)	-- ケイ思案
	CUT_CAMERA19	= set_camera(Camera_01_0410_19)
	CUT_CAMERA20	= set_camera(Camera_01_0410_20)
	CUT_CAMERA21	= set_camera(Camera_01_0410_21)
	CUT_CAMERA22	= set_camera(Camera_01_0410_22)
	CUT_CAMERA23	= set_camera(Camera_01_0410_23)
	CUT_CAMERA24	= set_camera(Camera_01_0410_24)
	CUT_CAMERA24_1_1	= set_camera(Camera_01_0410_24_1_1)
	CUT_CAMERA24_1_2	= set_camera(Camera_01_0410_24_1_2)
	CUT_CAMERA24_2_1	= set_camera(Camera_01_0410_24_2_1)
	CUT_CAMERA24_3_1	= set_camera(Camera_01_0410_24_3_1)
	CUT_CAMERA24_3_2	= set_camera(Camera_01_0410_24_3_2)
	CUT_CAMERA25	= set_camera(Camera_01_0410_25)
	CUT_CAMERA26	= set_camera(Camera_01_0410_26)
	CUT_CAMERA27	= set_camera(Camera_01_0410_27)
	CUT_CAMERA28	= set_camera(Camera_01_0410_28)
-- ------------------------------------------
end

-- シーケンスの実行
function Play()
	on_camera(CUT_CAMERA1)
		off_active(Arthur)  --アーサー非表示
	demo_start()
	show_current_script()

--[[
	MA_01104_100002		ケイ	退学、願いたいところだが
	MA_01104_100003		ノワール	…！
	MA_01104_100004		ディナタン	そ、そんな…
	MA_01104_100005		ケイ	学園内の平穏を守るのが私の仕事<br>王はさておき、私は貴公を認めたくはない
	MA_01104_100006		アーサー	俺をさておかれては困るなぁ義兄さん
	MA_01104_100007		ケイ	王の公務が多忙だからと、学内のことは<br>私に任せきりの貴公が言うことかね
	MA_01104_100008		アーサー	推薦入学を妬む者がいるならば<br>入学試験をパスすれば良いわけだな？
	MA_01104_100009		ケイ	今は試験など満足に出来まい？<br>その場所はもうカレドニアの支配地域だ
	MA_01104_100010		ノワール	入学試験？
	MA_01104_100011		アーサー	バルバロイと戦う素養の有無を<br>見定めるための儀式だ
	MA_01104_100012		ケイ	隣国キャメリアードの果てに突き立つ“剣”<br>それに触れ、共鳴が起こるか否か
	MA_01104_100013		アーサー	その剣の名は“カリバーン”<br>ブリテン史上、誰ひとり抜いたことのない剣だ
	MA_01104_100014		アーサー	“武器”に類する素質があるか否かが選定される<br>あれば“武器”に触れた者の力が呼び起こされる
	MA_01104_100015		ノワール	カリバーンの、共鳴…<br>それが起こらない場合は？
	MA_01104_100016		アーサー	戦えるほどの素質がないとされる<br>戦力外通告というやつだな！
	MA_01104_100017		ケイ	…もし仮に共鳴が起こったとして<br>キラーズ無き者に円卓は任せられぬよ
	MA_01104_100019		ランスロット	もし仮に<br>剣を抜くことができたなら？
	MA_01104_100020		ケイ	…………ありえんことだ<br>それではまるで──
	MA_01104_100021		ランスロット	儀式を経ないままでバルバロイは倒せない<br>あれは次元を異にする怪物だからだ
	MA_01104_100022		ランスロット	だがノワールはその行程を踏まず<br>バルバロイを倒せたと聞く、なぜだ？
	MA_01104_100023		アーサー	…
	MA_01104_100024		ケイ	…カリバーンを抜く者が現れるとなれば<br>ランスロット卿、それは──…いや、しかし
	MA_01104_100025		アーサー	まあ不公平は良くないな！<br>全生徒にやってもらってることだし！
	MA_01104_100026		ケイ	言っただろう、かの地はもはや<br>カレドニアに侵略しつくされ──
	MA_01104_100028		ギネヴィア	お目付け役が要るわね
	MA_01104_100029		ケイ	…ハァ。何故このような者を買います？<br>殿下はただ座していればいいものを
	MA_01104_100030		ギネヴィア	わたしのためでもあるの
	MA_01104_100031		ケイ	…テコでも動きませんか
	MA_01104_100032		ギネヴィア	止められたって出てってやるわ
	MA_01104_100033		ディナタン	兄さん、私も────…
	MA_01104_100034		ケイ	…ならば貴公は留守番としよう<br>ディナタン
	MA_01104_100035		ディナタン	どうして…！
	MA_01104_100036		ケイ	人質だ。出先で彼が裏切り、殿下を殺す…<br>といった事態も考えられる
	
	MA_01104_100038		選択肢１	推薦を無駄にしたくない
	MA_01104_100039		選択肢２	殿下に迷惑はかけられない
	MA_01104_100040		選択肢３	待っていてくれディナタン

	MA_01104_100042		ノワール	ランスロットがしてくれた推薦を<br>無駄にしたくない
	MA_01104_100043		ノワール	真意はわからないけどな
	MA_01104_100044		ランスロット	…期待させてくれ

	MA_01104_100046		ノワール	雇い主がお目付け役を<br>買って出てくれたんだ
	MA_01104_100047		ノワール	迷惑をかけるつもりはない<br>傭兵の誇りだ
	MA_01104_100048		ギネヴィア	お気遣いどーも

	MA_01104_100050		ノワール	キラーズだ儀式だと<br>わからないことだらけだが
	MA_01104_100051		ノワール	すぐに戻ってくる<br>待っていてくれディナタン
	MA_01104_100052		ディナタン	う、うん…<br>無茶しないでね？

	MA_01104_100054		ノワール	帰って来るよ。必ず<br>安心して待っていてくれ
	MA_01104_100055		ケイ	騎士たちが遠征から帰還次第<br>キャメリアードを取り戻す算段であったが…
	MA_01104_100056		アーサー	ははあ、さては義兄さん<br>危ないからヤメておけって言いたいわけだ
	MA_01104_100057		ケイ	…良かろう、バルバロイの制圧地域を抜けて<br>無事儀式を終えて見せよ
	MA_01104_100058		ケイ	仮に共鳴なく、素質なくば<br>帰る場所も失うと知れ
]]

	-- 選択1回目
	MA_01104_10_select1()
	open_select_window_direct(Noir, "Normal", "推薦を無駄にしたくない","殿下に迷惑はかけられない","待っていてくれディナタン")
	--open_select_window(Noir, "Normal")
	close_speech_window()
	-- 選択時に残していた会話テキストを消去

	if is_select(1) then
		MA_01104_10_select1_1()
	elseif is_select(2) then
		MA_01104_10_select1_2()
	elseif is_select(3) then
		MA_01104_10_select1_3()
	else
		-- 例外処理
	end

	MA_01104_10_end()
	demo_end()
end


function MA_01104_10_select1()
-- カット1 ----------------------------------------------------------------------------------------
		lookat_weight(Arthur, 0.3, 0.8, 1.0, 1.0) --アーサー顔の向き調整
		keep_ik_lookat(Arthur, Kay, "J_Head")

		lookat_weight(Noir, 0.3, 0.8, 1.0, 1.0) --ノワール顔の向き調整
		keep_ik_lookat(Noir, Kay, "J_Head")

		lookat_weight(Dinatan, 0.3, 0.8, 1.0, 1.0) --ディナタン顔の向き調整
		keep_ik_lookat(Dinatan, Kay, "J_Head")

		change_face(Kay, "Anger")
		slidemove(CUT_CAMERA1, Camera_01_0410_1_mov, 0.03)
		wait_time(0.07)
	open_speech_window("CHRNAME_KAY", nil, nil)
	message_direct("退学、願いたいところだが") --ケイ：退学、願いたいところだが
	close_speech_window()

-- カット2 ----------------------------------------------------------------------------------------
	on_camera(CUT_CAMERA2)
		on_active(Arthur)  --アーサー表示

		lookat_weight(Kay, 0.3, 0.8, 1.0, 1.0) --ケイ顔の向き調整
		keep_ik_lookat(Kay, Noir, "J_Head")

		motion_inloop(Noir, "Sri_Std_Surp_Start_m","Sri_Std_Surp_Loop_m", 0, 1.0)
		motion_inloop(Dinatan, "Sri_Std_Surp_Start_f","Sri_Std_Surp_Loop_f", 0, 1.0)
		change_face(Noir, "Sad")
		change_face(Dinatan, "Sad")

	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	message_direct("…！") --ノワール：…！
	close_speech_window()
	
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil)
	message_direct("そ、そんな…") --ディナタン：そ、そんな…
	close_speech_window()

-- カット3 ----------------------------------------------------------------------------------------
	on_camera(CUT_CAMERA3)
		change_face(Noir, "Normal")
		change_face(Dinatan, "Normal")

		motion(Dinatan,"Bea_Std02_Loop_f", 0,1.0, true)
		motion(Noir,"Sri_Std_loop_m", 0.3,1.0, true)
		change_face(Kay, "Normal")
		change_face(Arthur, "Smile")
	
	open_speech_window("CHRNAME_KAY", Kay, nil)
	message_direct("MA_01104_100005") -- ケイ：学園内の平穏を守るのが私の仕事
	close_speech_window()

		slidemove(CUT_CAMERA3, Camera_01_0410_3_mov, 2.6)
		turn(CUT_CAMERA3, Camera_01_0410_3_rot, 2.6)
	wait_time(0.6)
		
	open_speech_window("CHRNAME_ARTHUR", Arthur, nil)
	message_direct("MA_01104_100006") --アーサー：俺をさておかれては困るなぁ義兄さん
	close_speech_window()
	wait_time(1.1)

		motion_inloop(Kay, "Com_Std_BA01_Start_m","Com_Std_BA01_Loop_m", 0.3, 1.0)
	wait_time(1.0)

-- カット4 ----------------------------------------------------------------------------------------
	on_camera(CUT_CAMERA4)
		off_active(Dinatan)  --ディナタン非表示
		off_active(Noir)  --ノワール非表示

	open_speech_window("CHRNAME_KAY", nil, nil)
	message_direct("MA_01104_100007") --ケイ：王の公務が多忙だからと、学内のことは
	close_speech_window()

-- カット5 ----------------------------------------------------------------------------------------
	on_camera(CUT_CAMERA5)
		on_active(Dinatan)  --ディナタン非表示
		on_active(Noir)  --ディナタン非表示

		set_pos(Kay, Ky_01_000004_5_pos) --ケイ調整
		set_rot(Kay, Ky_01_000004_5_rot) --ケイ調整
		set_rot(Noir, No_01_000004_5_rot) --ノワール調整
		set_rot(Dinatan, Di_01_000004_5_pos) --ディナタン調整
		set_rot(Dinatan, Di_01_000004_5_rot) --ディナタン調整

		motion(Arthur,"Arthur_EntakuLeftSit_loop", 0.3,1.0, true)

	open_speech_window("CHRNAME_ARTHUR", nil, nil) --アーサー：推薦入学を妬む者がいるならば
	message_direct("MA_01104_100008")
	close_speech_window()


-- カット6 ----------------------------------------------------------------------------------------
	on_camera(CUT_CAMERA6)
		change_face(Noir, "Normal")
		change_face(Dinatan, "Normal")
		change_face(Arthur, "Normal")
		motion(Kay,"Com_Std_BA01_End_m", 0,1.0, false)

		lookat_weight(Arthur, 0, 0, 0, 0) --アーサー顔の向き調整
		keep_ik_lookat(Arthur, nil, false)

		slidemove(CUT_CAMERA6, Camera_01_0410_6_mov, 12)
	open_speech_window("CHRNAME_KAY", Kay, nil) --ケイ：今は試験など満足に出来まい？
	message_direct("MA_01104_100009")
	close_speech_window()
		
		motion_inloop(Noir, "Sri_Std_Talk_Start_m","Sri_Std_Talk_Loop_m", 0.3, 1.0)
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)
	message_direct("MA_01104_100010") --ノワール：入学試験？
	close_speech_window()
	
		motion(Noir,"Sri_Std_Talk_End_m", 0.3,1.0, false)
	wait_time(0.45)

-- カット8 ----------------------------------------------------------------------------------------
	fadeout(0,0,0,1.0, 0.1) --暴れ隠しIN
	wait_time(0.1)
	on_camera(CUT_CAMERA8)
		set_rot(Noir, No_01_000004_8_pos) --ノワール角度調整
		set_rot(Noir, No_01_000004_8_rot) --ノワール角度調整
		motion(Noir,"Sri_Std_loop_m", 0.3, 1.0, true) --あばれ調整
		set_rot(Dinatan, Di_01_000004_8_pos) --ディナタン角度調整
		set_rot(Dinatan, Di_01_000004_8_rot) --ディナタン角度調整
		set_pos(Kay, Ky_01_000004_8_pos) --ケイ位置調整
		set_rot(Kay, Ky_01_000004_8_rot) --ケイ位置調整
		--set_pos(Arthur, At_01_000004_8_pos) --アーサー位置調整
		--set_rot(Arthur, At_01_000004_8_rot) --アーサー位置調整

		motion(Kay,"Col_Std_loop_m", 0.3, 1.0, true) --あばれ調整

	wait_time(0.06)
	fadein(0,0,0,1.0, 0.1) --暴れ隠しOUT

	open_speech_window("CHRNAME_ARTHUR", Arthur, nil) --アーサー：バルバロイと戦う素養の有無を
	message_direct("MA_01104_100011")
	close_speech_window()

	fadein(1.6)
	fadeout(0, 0,0,50, 1.6)
	
-- カット9 ----------------------------------------------------------------------------------------
-- 剣の祭壇
	on_camera(CUT_CAMERA9)
	show_image("MA011041001", 0.0, 0.0, 2.2)--地図
	wait_time(1.1)

	open_simple_window("CHRNAME_KAY", Kay, nil) --ケイ： 隣国キャメリアードの果てに突き立つ剣
		message_direct("MA_01104_100012")
	close_speech_window()

	--画面外のキャラ調整-------------------------------------------------------------
		set_pos(Kay, Ky_01_000004_10_pos) --ケイ位置調整
		set_rot(Kay, Ky_01_000004_10_rot) --ケイ位置調整
		set_pos(Lancelot, La_01_000004_1_pos) --ランスロット位置調整
		set_rot(Lancelot, La_01_000004_1_rot) --ランスロット位置調整
		motion(Noir,"Sri_Std_loop_m", 0.6,1.0, true)
	--------------------------------------------------------------------------------

	hide_image(1.0)
	wait_time(1.0)
	
	show_image("MA011041002", 0.0, 0.0, 1.6)--剣の祭壇
	wait_time(1.0)

	open_simple_window("CHRNAME_ARTHUR", Arthur, nil)-- アーサー：
		message_direct("MA_01104_100013")
	close_speech_window()

	open_simple_window("CHRNAME_ARTHUR", Arthur, nil) --アーサー：
		message_direct("MA_01104_100014")
	close_speech_window()
	
	hide_image(1.0)
	
-- カット10 ----------------------------------------------------------------------------------------
	fadeout(0,0,0,1.0, 0.1) --暴れ隠しIN
	wait_time(0.1)
		--lookat_weight(Arthur, 0.3, 0.8, 1.0, 1.0) --アーサー顔の向き調整
		--keep_ik_lookat(Arthur, Kay, "J_Head")

	on_camera(CUT_CAMERA10)

	wait_time(0.09)
	fadein(0,0,0,1.0, 0.1) --暴れ隠しOUT

	open_speech_window("PLAYERNAME_NOIR", nil, nil)
	message_direct("MA_01104_100015") --ノワール：カリバーンの、共鳴…
	close_speech_window()

-- カット11 ----------------------------------------------------------------------------------------
	--fadeout(0,0,0,1.0, 0.1) --暴れ隠しIN
	--wait_time(0.1)

	on_camera(CUT_CAMERA11)	
		change_face(Arthur, "Smile")
		change_face(Kay, "Anger")
		--motion(Kay, "Col_Std_loop_m", 0.3, 1.0, true) --あばれ調整
	--wait_time(0.06)
	--fadein(0,0,0,1.0, 0.1) --暴れ隠しOUT

	open_speech_window("CHRNAME_ARTHUR", Arthur, nil) --アーサー：戦えるほどの素質がないとされる
	message_direct("MA_01104_100016111111")
	close_speech_window()

		motion_inloop(Kay, "Col_Std_no_m","Col_Std_loop_m", 0.3, 1.0)
	open_speech_window("CHRNAME_KAY", Kay, nil) --ケイ：…もし仮に共鳴が起こったとして
	message_direct("MA_01104_100017")
	close_speech_window()

--リセット
	motion(Arthur,"Arthur_EntakuSit_loop", 0.3,1.0, true)

-- カット12 ----------------------------------------------------------------------------------------
-- ランスロットアップ
	on_camera(CUT_CAMERA12)
	--画面外のキャラ位置調整---------------------------------------------------------
		set_pos(Noir, No_01_000004_12_pos) --ノワール位置調整
		set_rot(Noir, No_01_000004_12_rot) --ノワール位置調整
		set_pos(Dinatan, Di_01_000004_12_pos) --ディナタン位置調整
		set_rot(Dinatan, Di_01_000004_12_rot) --ディナタン位置調整
		set_pos(Kay, Ky_01_000004_12_pos) --ケイ位置調整
		set_rot(Kay, Ky_01_000004_12_rot) --ケイ位置調整
	--------------------------------------------------------------------------------

	open_speech_window("CHRNAME_LANCELOT", nil, nil)  --ランスロット：もし仮に
	message_direct("MA_01104_100019")
	close_speech_window()
	
------ CUT_CAMERA12_2------------------------------------------------
-- ランスロット歩いてくる
	fadeout(0,0,0,1.0, 0.1) --暴れ隠しIN
	wait_time(0.1)
	on_camera(CUT_CAMERA12_2)

		motion(Lancelot, "Sri_Wlk_loop_m", 0, 1.0, true)
		groundmove(Lancelot, La_01_000004_12_mov, 1.86)

	wait_time(0.06)
	fadein(0,0,0,1.0, 0.1) --暴れ隠しOUT

	wait_time(0.5)
		slidemove(CUT_CAMERA12_2, Camera_01_0410_12_2_pos, 1.2)
		turn(CUT_CAMERA12_2, Camera_01_0410_12_2_rot, 1.2)
	wait_time(0.2)

		lookat_weight(Kay, 0.3, 0.8, 1.0, 1.0) --ケイ顔の向き調整
		keep_ik_lookat(Kay, Lancelot, "J_Head")

		motion(Kay, "Mob_Std_180turn_left_m", 0.3, 0.7, false)
	wait_time(1.0)
	
------ CUT_CAMERA13------------------------------------------------
-- ケイ振り向く
	fadeout(0,0,0,1.0, 0.1) --暴れ隠しIN
	wait_time(0.1)
	on_camera(CUT_CAMERA13)
	
		change_face(Kay, "Surprise")
		set_rot(Kay, Ky_01_000004_13_rot) --ケイ回転

		motion(Kay, "Col_Std01_Loop_m", 0, 1.0, true) --暴れ調整
		motion(Lancelot, "Col_Std_loop_m", 0.3, 1.0, true)
		set_pos(Lancelot, La_01_000004_13_pos) --ランスロット位置調整
		set_rot(Lancelot, La_01_000004_13_rot) --ランスロット位置調整

	wait_time(0.06)
	fadein(0,0,0,1.0, 0.1) --暴れ隠しOUT

	open_speech_window("CHRNAME_KAY", nil, nil)   --ケイ：…………ありえんことだ
	message_direct("MA_01104_100020")
	close_speech_window()


------ CUT_CAMERA14------------------------------------------------
-- ランスロット手前
	on_camera(CUT_CAMERA14)
		set_pos(Kay, Ky_01_000004_14_pos) --ケイ位置調整
		set_rot(Kay, Ky_01_000004_14_rot) --ケイ位置調整

		lookat_weight(Noir, 0.3, 0.8, 1.0, 1.0) --ノワール顔の向き調整
		keep_ik_lookat(Noir, Lancelot, "J_Head")

		lookat_weight(Dinatan, 0.3, 0.8, 1.0, 1.0) --ディナタン顔の向き調整
		keep_ik_lookat(Dinatan, Lancelot, "J_Head")

		motion(Kay, "Col_Std01_Loop_m", 0, 1.0, true) --暴れ調整
		motion_inloop(Lancelot, "Col_Std_talk02_loop_m","Col_Std_loop_m", 0, 1.0)

		slidemove(CUT_CAMERA14, Camera_01_0410_14_pos, 11)
		turn(CUT_CAMERA14, Camera_01_0410_14_rot, 11)

	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)   --ランスロット：儀式を経ないままでバルバロイは倒せない
	message_direct("MA_01104_100021")
	close_speech_window()
		
	open_speech_window("CHRNAME_LANCELOT", Lancelot, nil)   --ランスロット：
	message_direct("MA_01104_100022")
	close_speech_window()

------ CUT_CAMERA15------------------------------------------------
-- ノワール
	on_camera(CUT_CAMERA15)

		--set_pos(Arthur, At_01_000004_8_pos) --アーサー位置調整
		--set_rot(Arthur, At_01_000004_8_rot) --アーサー位置調整

		lookat_weight(Arthur, 0, 0, 0, 0) --アーサー顔の向き調整
		keep_ik_lookat(Arthur, nil, false)

		motion(Lancelot,"Col_Std01_Loop_m", 0.3,1.0, true) --画面外ランスロットモーション調整
	wait_time(0.91)


------ CUT_CAMERA16------------------------------------------------
-- アーサー思案
change_face(Arthur, "Sad")
	on_camera(CUT_CAMERA16)
		set_pos(Noir, No_01_000004_16_pos) --ノワール調整
		set_rot(Noir, No_01_000004_16_rot) --ノワール調整
		set_pos(Dinatan, Di_01_000004_16_pos) --ディナタン調整
		set_rot(Dinatan, Di_01_000004_16_rot) --ディナタン調整
	open_speech_window("CHRNAME_ARTHUR", nil, nil) --アーサー：…
	lipsync(Arthur, "FixedClose")
	message_direct("MA_01104_100023")
	close_speech_window()

------ CUT_CAMERA17------------------------------------------------
-- ケイ思案
	on_camera(CUT_CAMERA17)
	open_speech_window("CHRNAME_KAY", Kay, nil)  --ケイ：…カリバーンを抜く者が現れるとなれば
	message_direct("MA_01104_100024")
	close_speech_window()

------ CUT_CAMERA18------------------------------------------------
-- アーサー手前
	fadeout(0,0,0,1.0, 0.1) --暴れ隠しIN
	wait_time(0.1)
	on_camera(CUT_CAMERA8)
		
		change_face(Arthur, "Smile")
		set_pos(Kay, Ky_01_000004_8_pos) --ケイ位置調整
		set_rot(Kay, Ky_01_000004_8_rot) --ケイ位置調整

		lookat_weight(Noir, 0.3, 0.8, 1.0, 1.0) --ノワール顔の向き調整
		keep_ik_lookat(Noir,  Arthur, "J_Head")

		lookat_weight(Dinatan, 0.3, 0.8, 1.0, 1.0) --ディナタン顔の向き調整
		keep_ik_lookat(Dinatan,  Arthur, "J_Head")

		motion(Kay, "Col_Std_loop_m", 0, 1.0, true) --暴れ調整

	wait_time(0.06)
	fadein(0,0,0,1.0, 0.1) --暴れ隠しOUT

	open_speech_window("CHRNAME_ARTHUR", Arthur, nil) --アーサー：まあ不公平は良くないな！
	message_direct("MA_01104_100025")
	close_speech_window()

		change_face(Kay, "Normal")
		motion_inloop(Kay, "Com_Std_BA02_Start_m","Com_Std_BA02_Loop_m", 0.3, 1.0)

		lookat_weight(Kay, 0.3, 0.8, 1.0, 1.0) --ケイ顔の向き調整
		keep_ik_lookat(Kay, Arthur, "J_Head")

	open_speech_window("CHRNAME_KAY", Kay, nil)   --ケイ：言っただろう、かの地はもはや
	message_direct("MA_01104_100026")
	close_speech_window()

	
------ CUT_CAMERA19------------------------------------------------
-- ギネヴィア、立ちはだかる
	on_camera(CUT_CAMERA19)
	set_camera_nearclip(CUT_CAMERA19,1.6)
	--------------------------------------------------------------
		set_pos(Kay, Ky_01_000004_19_pos) --ケイ調整
		set_rot(Kay, Ky_01_000004_19_rot) --ケイ調整
		motion(Kay,"Col_Std_loop_m", 0.3, 1.0, true) --あばれ調整
		set_pos(Guinevere, Gu_01_000004_1_pos) --ギネヴィア調整
		set_rot(Guinevere, Gu_01_000004_1_rot) --ギネヴィア調整	
		set_pos(Gwenhwymawr, Gw_01_000004_1_pos) --ギネマウア調整
		set_rot(Gwenhwymawr, Gw_01_000004_1_rot) --ギネマウア調整
		set_pos(Noir, No_01_000004_19_pos) --ノワール調整
		set_rot(Noir, No_01_000004_19_rot) --ノワール調整
		set_pos(Dinatan, Di_01_000004_19_pos) --ディナタン調整
		set_rot(Dinatan, Di_01_000004_19_rot) --ディナタン調整

		lookat_weight(Noir, 0.3, 0.8, 1.0, 1.0) --ノワール顔の向き調整
		keep_ik_lookat(Noir,  Guinevere, "J_Head")

		lookat_weight(Dinatan, 0.3, 0.8, 1.0, 1.0) --ディナタン顔の向き調整
		keep_ik_lookat(Dinatan,  Guinevere, "J_Head")

		lookat_weight(Guinevere, 0.3, 0.8, 1.0, 1.0) --ギネヴィア顔の向き調整
		keep_ik_lookat(Guinevere,  Kay, "J_Head")

		lookat_weight(Gwenhwymawr, 0.3, 0.8, 1.0, 1.0) --ギネマウア顔の向き調整
		keep_ik_lookat(Gwenhwymawr,  Kay, "J_Head")

		change_face(Arthur, "Normal")
	--------------------------------------------------------------
	
		motion(Guinevere, "Nbl_Wlk_loop_f", 0, 1.0, true)
		change_face(Noir, "Surprise")
		motion(Gwenhwymawr, "Mob_Wlk_loop_f", 0, 1.0, true)
		slidemove(Guinevere, Gu_01_000004_19_mov, 0.96)
		slidemove(Gwenhwymawr, Gw_01_000004_19_mov, 0.96)
	wait_time(0.66)
		motion_inloop(Guinevere, "Nbl_Wlk_Std_f","Nbl_Std_loop_f", 0.3, 1.0)
	wait_time(0.3)
		motion(Gwenhwymawr,"Bea_Std02_Loop_f", 0.3,1.0, true)

	wait_time(0.6)
	turn(CUT_CAMERA19, Camera_01_0410_19_rot, 0.22)
	wait_time(0.22)	

	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)   --ギネヴィア：お目付け役がいるわね
	message_direct("MA_01104_100028")
	close_speech_window()

------ CUT_CAMERA20------------------------------------------------
-- ギネヴィア、ケイ対峙
	fadeout(0,0,0,1.0, 0.1) --暴れ隠しIN
	wait_time(0.1)
	on_camera(CUT_CAMERA20)
		
		lookat_weight(Noir, 0.3, 0.8, 1.0, 1.0) --ノワール顔の向き調整
		keep_ik_lookat(Noir, Kay, "J_Head")

		lookat_weight(Dinatan, 0.3, 0.8, 1.0, 1.0) --ディナタン顔の向き調整
		keep_ik_lookat(Dinatan,  kay, "J_Head")

	--キャラ位置再設定---------------------------------------------
		set_pos(Noir, No_01_000004_20_pos) --ノワール位置調整
		set_rot(Noir, No_01_000004_20_rot) --ノワール位置調整
		motion(Noir, "Sri_Std_loop_m", 0, 1.0, true) --暴れ調整
		set_rot(Gwenhwymawr, Gw_01_000004_20_pos) --ギネマウア位置調整
		set_rot(Gwenhwymawr, Gw_01_000004_20_rot) --ギネマウア位置調整
		--set_pos(Lancelot, La_01_000004_20_pos) --ランスロット位置調整

		lookat_weight(Kay, 0.3, 0.8, 1.0, 1.0) --ケイ顔の向き調整
		keep_ik_lookat(Kay, Guinevere, "J_Head")
	---------------------------------------------------------------
		motion(Kay,"Col_Std_loop_m", 0,1.0, true)
		change_face(Noir, "Normal")
		change_face(Kay, "Sad")

	wait_time(0.06)
	fadein(0,0,0,1.0, 0.1) --暴れ隠しOUT

	open_speech_window("CHRNAME_KAY", Kay, nil)  --ケイ：…ハァ。何故このような者を買います？
	message_direct("MA_01104_100029")
	close_speech_window()

		motion_inloop(Guinevere, "Nbl_Std_talk_loop_f","Nbl_Std_loop_f", 0.3, 1.0)
	open_speech_window("CHRNAME_GUINEVERE", Guinevere, nil)   --ギネヴィア：わたしのためでもあるの
	message_direct("MA_01104_100030")
	close_speech_window()

------ CUT_CAMERA21------------------------------------------------
	on_camera(CUT_CAMERA21)
	--キャラ位置再設定---------------------------------------------
		set_pos(Noir, No_01_000004_24_pos) --ノワール位置調整
		set_rot(Noir, No_01_000004_24_rot) --ノワール位置調整
		set_pos(Dinatan, Di_01_000004_23_pos) --ディナタン位置調整
		set_rot(Dinatan, Di_01_000004_23_rot) --ディナタン位置調整
		set_pos(Guinevere, Gu_01_000004_24_pos) --ギネヴィア位置調整
		set_rot(Guinevere, Gu_01_000004_24_rot) --ギネヴィア位置調整
		set_pos(Gwenhwymawr, Gw_01_000004_24_pos) --ギネマウア位置調整
		set_rot(Gwenhwymawr, Gw_01_000004_24_rot) --ギネマウア位置調整
		off_active(Lancelot)  --ランスロット表示
	----------------------------------------------------------------

		change_face(Kay, "Normal")
		motion(Noir, "Sri_Std_loop_m", 0, 1.0, true)
	open_speech_window("CHRNAME_KAY", nil, nil) --ケイ：…テコでも動きませんか
	message_direct("MA_01104_100031")
	close_speech_window()

------ CUT_CAMERA22------------------------------------------------
	fadeout(0,0,0,1.0, 0.1) --暴れ隠しIN
	wait_time(0.1)
	on_camera(CUT_CAMERA22)	

	--キャラ位置再設定---------------------------------------------
		set_pos(Kay, Ky_01_000004_24_pos) --ケイ位置調整
		set_rot(Kay, Ky_01_000004_24_rot) --ケイ位置調整
		set_pos(Lancelot, La_01_000004_24_1_pos) --ランスロット位置調整
		set_rot(Lancelot, La_01_000004_24_1_rot) --ランスロット位置調整
	----------------------------------------------------------------
		motion(Guinevere,"Nbl_Std_loop_f", 0,1.0, true)
		change_face(Guinevere, "Normal")

	wait_time(0.06)
	fadein(0,0,0,1.0, 0.1) --暴れ隠しOUT

	open_speech_window("CHRNAME_GUINEVERE", nil, nil)   --ギネヴィア：止められたって出てってやるわ
	message_direct("MA_01104_100032")
	close_speech_window()


------ CUT_CAMERA23------------------------------------------------
	fadeout(0,0,0,1.0, 0.1) --暴れ隠しIN
	wait_time(0.1)
	on_camera(CUT_CAMERA23)

		motion_inloop(Dinatan, "Mob_Std_yes_f","Mob_Std_loop_f", 0.3, 0.6)
		lookat_weight(Dinatan, 0.3, 0.8, 1.0, 1.0) --ディナタン顔の向き調整
		keep_ik_lookat(Dinatan,  Noir, "J_Head")
		on_active(Lancelot)  --ランスロット表示

	wait_time(0.06)
	fadein(0,0,0,1.0, 0.1) --暴れ隠しOUT

		change_face(Dinatan, "Anger")
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil) --ディナタン：兄さん、私も────…
	message_direct("MA_01104_100033")
	close_speech_window()

------ CUT_CAMERA24------------------------------------------------
-- ケイと学生たち
	fadeout(0,0,0,1.0, 0.1) --暴れ隠しIN
	wait_time(0.1)
	on_camera(CUT_CAMERA24)

		change_face(Kay, "Normal")
		set_pos(Dinatan, Di_01_000004_24_pos) --ディナタン位置調整
		set_rot(Dinatan, Di_01_000004_24_rot) --ディナタン位置調整
		lookat_weight(Kay, 0.3, 0.8, 1.0, 1.0) --ケイ顔の向き調整
		keep_ik_lookat(Kay, Dinatan, "J_Head")
		motion(Dinatan, "Mob_Std_loop_f", 0.3, 1.0, true) --あばれ調整
		motion(Lancelot, "Col_Std_loop_m", 0.3, 1.0, true) --あばれ調整

	wait_time(0.06)
	fadein(0,0,0,1.0, 0.1) --暴れ隠しOUT

		open_speech_window("CHRNAME_KAY", Kay, nil) --ケイ：…ならば貴公は留守番としよう
	message_direct("MA_01104_100034")
	close_speech_window()

		change_face(Dinatan, "Pain")
		motion_inloop(Dinatan, "Sri_Std_No_Start_f","Sri_Std_No_Loop_f", 0.3, 1.0)
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil) --ディナタン：
	message_direct("MA_01104_100035")
	close_speech_window()
		motion_inloop(Dinatan, "Sri_Std_No_End_f","Mob_Std_loop_f", 0.3, 0.6)
		motion_inloop(Kay, "Com_Std_BA01_Start_m","Com_Std_BA01_Loop_m", 0.3, 1.0)

	open_speech_window("CHRNAME_KAY", Kay, nil) --ケイ：
	message_direct("MA_01104_100036")
	close_speech_window()
	
		change_face(Dinatan, "Normal")

end

function MA_01104_10_select1_1()
-- 選択肢1
------ CUT_CAMERA24_1------------------------------------------------
	on_camera(CUT_CAMERA24_1_1)
		off_active(Kay)  --ケイ表示
	open_speech_window("PLAYERNAME_NOIR", nil, Noir) --ノワール
	message_direct("MA_01104_100042")
	close_speech_window()

		motion_inloop(Noir, "Sri_Std_no_m","Sri_Std_loop_m", 0.3, 1.0)
	open_speech_window("PLAYERNAME_NOIR", nil, Noir) --ノワール
	message_direct("MA_01104_100043")
	close_speech_window()

	on_camera(CUT_CAMERA24_1_2)
		motion_inloop(Lancelot, "Col_Std_yes_m","Col_Std_loop_m", 0.3, 1.0)
	open_speech_window("CHRNAME_LANCELOT", nil, nil) --ランスロット
	message_direct("MA_01104_100044")
	close_speech_window()

		on_active(Kay)  --ケイ表示
end


function MA_01104_10_select1_2()
-- 選択肢2		
------ CUT_CAMERA24_2------------------------------------------------
	on_camera(CUT_CAMERA24_2_1)
		off_active(Dinatan)  --ディナタン非表示
		motion_inloop(Noir, "Sri_Std_Talk_Start_m","Sri_Std_Talk_Loop_m", 0.6, 1.0)
	open_speech_window("PLAYERNAME_NOIR", nil, Noir)   --ノワール
	message_direct("MA_01104_100046")
	close_speech_window()

	open_speech_window("PLAYERNAME_NOIR", nil, Noir)   --ノワール
	message_direct("MA_01104_100047")
	close_speech_window()
	
		motion_inloop(Noir,"Sri_Std_Talk_End_m","Sri_Std_loop_m", 0.3, 1.0)
		motion_inloop(Guinevere, "Nbl_Std_talk_loop_f","Nbl_Std_loop_f", 0.6, 1.0)
		slidemove(CUT_CAMERA24_2_1, Camera_01_0410_24_2_1_mov, 0.09)
		turn(CUT_CAMERA24_2_1, Camera_01_0410_24_2_1_turn, 0.09)
		wait_time(0.19)

	open_speech_window("CHRNAME_GUINEVERE", nil, nil)   --ギネヴィア
	message_direct("MA_01104_100048")
	close_speech_window()
end

function MA_01104_10_select1_3()
-- 選択肢3
------ CUT_CAMERA24_3------------------------------------------------
		motion(Noir, "Mob_Std_180turn_right_m", 0.3, 1.0, false)
	wait_time(0.52)

	on_camera(CUT_CAMERA24_3_1)
		change_face(Dinatan, "Sad")
		motion(Noir, "Sri_Std_loop_m", 0, 1.0, true)

	--キャラ位置再設定---------------------------------------------
		set_rot(Noir, No_01_000004_24_3_2_rot) --ノワール位置調整
		set_pos(Dinatan, Di_01_000004_24_3_2_pos) --ディナタン位置調整
		set_rot(Dinatan, Di_01_000004_24_3_2_rot) --ディナタン位置調整
	---------------------------------------------------------------

	open_speech_window("PLAYERNAME_NOIR", nil, Noir)   --ノワール
	message_direct("MA_01104_100050")
	close_speech_window()

	open_speech_window("PLAYERNAME_NOIR", nil, Noir)   --ノワール
	message_direct("MA_01104_100051")
	close_speech_window()

		motion_inloop(Dinatan, "Mob_Std_yes_f","Mob_Std_loop_f", 0.3, 1.0)
	open_speech_window("CHRNAME_DINATAN", Dinatan, nil) --ディナタン
	message_direct("MA_01104_100052")
	close_speech_window()
	
		motion(Noir,"Mob_Std_yes_m", 0.3,1.0, false)
	wait_time(0.91)

		motion(Noir, "Mob_Std_180turn_left_m", 0.3, 1.0, false)
	wait_time(0.52)
		motion(Noir, "Sri_Std_loop_m", 0.3, 1.0, true) --あばれ調整
end

-- 合流
function MA_01104_10_end()
-- CUT_CAMERA25 ----------------------------------------------------------------------------------------
	fadeout(0,0,0,1.0, 0.1) --暴れ隠しIN
	wait_time(0.1)
	on_camera(CUT_CAMERA25)

	--キャラ位置再設定---------------------------------------------
		off_active(Dinatan)  --ディナタン非表示
		off_active(Lancelot)  --ランスロット非表示
		set_rot(Noir, No_01_000004_24_rot) --ノワール位置調整
		set_pos(Dinatan, Di_01_000004_24_pos) --ディナタン位置調整
		set_rot(Dinatan, Di_01_000004_24_rot) --ディナタン位置調整
		set_pos(Lancelot, La_01_000004_24_1_pos) --ランスロット位置調整
		set_rot(Lancelot, La_01_000004_24_1_rot) --ランスロット位置調整

		lookat_weight(Kay, 0, 0, 0, 0) --ケイ顔の向き調整
		keep_ik_lookat(Kay, nil, false)

		motion(Kay,"Col_Std_loop_m", 0.3, 1.0, true)--あばれ調整
	----------------------------------------------------------------
	wait_time(0.06)
	fadein(0,0,0,1.0, 0.1) --暴れ隠しOUT
	
	open_speech_window("PLAYERNAME_NOIR", nil, nil)
	message_direct("MA_01104_100054") --ノワール：帰って来るよ。必ず
	close_speech_window()

------ CUT_CAMERA26------------------------------------------------
	on_camera(CUT_CAMERA24)
		on_active(Dinatan)  --ディナタン表示
		change_face(Kay, "Normal")
	open_speech_window("CHRNAME_KAY", Kay, nil)  --ケイ：騎士たちが遠征から帰還次第
		message_direct("MA_01104_100055")
	close_speech_window()


------ CUT_CAMERA5------------------------------------------------
	fadeout(0,0,0,1.0, 0.1) --暴れ隠しIN
	wait_time(0.1)
	on_camera(CUT_CAMERA5)
	
		--set_pos(Arthur, At_01_000004_11_pos) --アーサー位置調整
		--set_rot(Arthur, At_01_000004_11_rot) --アーサー位置調整
		lookat_weight(Arthur, 0.3, 0.8, 1.0, 1.0) --アーサー顔の向き調整
		keep_ik_lookat(Arthur, Kay, "J_Head")

	--キャラ位置再設定---------------------------------------------
		set_pos(Noir, No_01_000004_26_pos) --ノワール位置調整
		set_rot(Noir, No_01_000004_26_rot) --ノワール位置調整
		set_pos(Dinatan, Di_01_000004_26_pos) --ディナタン位置調整
		set_rot(Dinatan, Di_01_000004_26_rot) --ディナタン位置調整
		set_pos(Guinevere, Gu_01_000004_26_pos) --ギネヴィア位置調整
		set_rot(Guinevere, Gu_01_000004_26_rot) --ギネヴィア位置調整
		set_pos(Gwenhwymawr, Gw_01_000004_26_pos) --ギネマウア位置調整
		set_rot(Gwenhwymawr, Gw_01_000004_26_rot) --ギネマウア位置調整
	----------------------------------------------------------------

		motion(Arthur,"Arthur_EntakuLeftSit_loop", 0.3,1.0, true)
		change_face(Arthur, "Smile")
	--キャラ位置再設定---------------------------------------------
		set_pos(Kay, Ky_01_000004_10_pos) --ケイ位置調整
		set_rot(Kay, Ky_01_000004_10_rot) --ケイ位置調整

	----------------------------------------------------------------
		motion(Dinatan,"Bea_Std02_Loop_f", 0,1.0, true)

	wait_time(0.06)
	fadein(0,0,0,1.0, 0.1) --暴れ隠しOUT

	open_speech_window("CHRNAME_ARTHUR", nil, nil)  --アーサー
		message_direct("MA_01104_100056")
	close_speech_window()

	--------------------------------------------------------------
		lookat_weight(Noir, 0, 0, 0, 0) --ノワール顔の向き調整
		keep_ik_lookat(Noir,  nil, false)

		lookat_weight(Dinatan,  0, 0, 0, 0) --ディナタン顔の向き調整
		keep_ik_lookat(Dinatan,  nil, false)

		lookat_weight(Guinevere,  0, 0, 0, 0) --ギネヴィア顔の向き調整
		keep_ik_lookat(Guinevere,  nil, false)

		lookat_weight(Gwenhwymawr,  0, 0, 0, 0) --ギネマウア顔の向き調整
		keep_ik_lookat(Gwenhwymawr,  nil, false)

		change_face(Arthur, "Normal")
	--------------------------------------------------------------

------ CUT_CAMERA26------------------------------------------------
	fadeout(0,0,0,1.0, 0.1) --暴れ隠しIN
	wait_time(0.1)
	on_camera(CUT_CAMERA26)
	set_camera_nearclip(CUT_CAMERA26,1.3)

		change_face(Kay, "Normal")
		motion_inloop(Kay, "Col_Std_no_m","Col_Std_loop_m", 0, 1.0)

	wait_time(0.06)
	fadein(0,0,0,1.0, 0.1) --暴れ隠しOUT

	wait_time(1.1)
		slidemove(CUT_CAMERA26, Camera_01_0410_26_mov, 0.2)
		turn(CUT_CAMERA26, Camera_01_0410_26_rot, 0.2)

	open_speech_window("CHRNAME_KAY", Kay, nil)  --ケイ：
	message_direct("MA_01104_100057")
	close_speech_window()

------ CUT_CAMERA27------------------------------------------------
	fadeout(0,0,0,1.0, 0.1) --暴れ隠しIN
	wait_time(0.1)
	on_camera(CUT_CAMERA27)
		change_face(Dinatan, "Anger")
		change_face(Guinevere, "Anger")
		set_pos(Kay, Ky_01_000004_27_0_pos) --ケイ位置調整

	wait_time(0.06)
	fadein(0,0,0,1.0, 0.1) --暴れ隠しOUT

	wait_time(0.9)
		turn(CUT_CAMERA27, Camera_01_0410_27_rot, 0.21)
	wait_time(0.9)
		set_pos(Kay, Ky_01_000004_27_pos) --ケイ位置調整
		set_rot(Kay, Ky_01_000004_27_rot) --ケイ位置調整
		motion_inloop(Kay, "Com_Std_Finger_Start_m","Com_Std_Finger_Loop_m", 0.3, 1.0)
	wait_time(1.44)

------ CUT_CAMERA28------------------------------------------------
	fadeout(0,0,0,1.0, 0.1) --暴れ隠しIN
	wait_time(0.1)
	on_camera(CUT_CAMERA28)
		
		motion(Kay,"Com_Std_Finger_Loop_m", 0, 1.0, true)
		set_pos(Kay, Ky_01_000004_28_pos) --ケイ位置調整
		set_rot(Kay, Ky_01_000004_28_rot) --ケイ位置調整
		change_face(Kay, "Anger")

	wait_time(0.06)
	fadein(0,0,0,1.0, 0.1) --暴れ隠しOUT

	open_speech_window("CHRNAME_KAY", nil, nil)  --ケイ：仮に共鳴なく、素質なくば
	message_direct("MA_01104_100058")
	close_speech_window()
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	load_area_scene_preload(110051)
	load_image_preload("MA011041001", "content_image_beta3_ma0110410", "MA011041001")
	load_image_preload("MA011041002", "content_image_beta3_ma0110410", "MA011041002")
	setup_Noir_preload(No_01_000004_1)
	setup_Dinatan_preload(Di_01_000004_1)
	setup_101015_Arthur_preload(At_01_000004_1, "Arthur_EntakuSit_loop", 0, true)
	setup_Kay_preload(Ky_01_000004_1)
	setup_Lancelot_preload(La_01_000004_0)
	setup_Guinevere_preload(Gu_01_000004_0)
	setup_Gwenhwymawr_preload(Gw_01_000004_0)
end
