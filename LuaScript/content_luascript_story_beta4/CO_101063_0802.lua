-- このluaスクリプトは、CO_101063_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力

	--★★クリスティーナ★★:一応、経緯を説明しておくとね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020002")


	--★★クリスティーナ★★:アストラット郷の名士のひとりが亡くなったから<br>その方の蔵書を寄贈してくれるんですって
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020003")

	open_select_window_tag(Actor001,"Normal","CO_101063_08020005","CO_101063_08020006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ありがたい話だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_08020008")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:ホントよね～！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020009")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:ログレスと関係のあった方みたいで<br>わざわざ遺言を遺してくれたんですって
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020010")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:この好意を無駄にしないようにしなくちゃ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どのくらいの量があるんだろう<br>送ってくれればよかったのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_08020013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "否定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:そんなこと言わないの！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020014")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:蔵書を譲ってくれるだけでも<br>ありがたいことなんだから
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020015")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:そういえば、前の話の続きだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_08020017")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:あら<br>気になってしょうがなかったって顔ね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:それはそうさ<br>あんなにいいところで中断されたんだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_08020019")

-- ▼直接出力
CloseTalkWindow()
wait_time(2)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:私はかろうじて命を取り留めた…<br>いえ、命だけは助けてもらえたけど
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020021")


	--★★クリスティーナ★★:利き腕で満足に武器を振るうことは<br>できなくなっていたわ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020022")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "苦しみ")
-- ▲直接出力

	--★★クリスティーナ★★:私に残されたのは『荒獅子ゴッデム』の悪名だけ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020023")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★クリスティーナ★★:道を歩けば後ろ指を指され、嗤われる日陰を渡り歩く日々よ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力

	--★★クリスティーナ★★:あの騎士を呪ったわなぜいっそ殺してくれなかったのか
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★クリスティーナ★★:そして私はひとつの考えに至ったの殺してもらえなかったのなら自分で死ねばいい
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020027")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0021")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:クリスさん…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_08020028")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:ある夜、私は身を投げるためにロンディニウムの大きな橋の上に立ったわ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020029")


	--★★クリスティーナ★★:そのとき、小さな女の子に手をつかまれたの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020031")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クリスティーナ★★:「悲しい目をしてちゃだめだよ」女の子はそう言って１冊の絵本を渡してきたわ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020032")


	--★★クリスティーナ★★:絵本に書かれていたのは絶望の淵にいたお姫様が度重なる苦難を乗り越え
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定")
-- ▲直接出力

	--★★クリスティーナ★★:最終的に異国の王子様と結ばれるというお話…よくある童話よ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020034")


	--★★クリスティーナ★★:でも、私は絵本を読んで涙したわ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020036")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力

	--★★クリスティーナ★★:それが感動の涙だったのか後悔の涙だったのか今となってはわからないけどね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020037")


	--★★クリスティーナ★★:そのあと私は本に救われた者として本の持つ力をみんなに伝えていく決意をしたの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020038")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力

	--★★クリスティーナ★★:傭兵『荒獅子ゴッデム』の名を棄てて司書『クリスティーナ』としてね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101063_08020041","CO_101063_08020042")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Appl")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:『荒獅子ゴッデム』だった過去は消せないし消してはいけないことだと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_08020044")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:だから償っていけばいいんだよ『クリスティーナ』として
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_08020045")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:くだんの騎士が命を奪わなかったのは<br>そのためなんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_08020046")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:そうね…うん、そうだと思う
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020047")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_08020049")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:も、もう！なんとか言ってよノワールちゃん
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020050")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★クリスティーナ★★:私ひとりでずっと喋ってて恥ずかしいじゃない…！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020051")

	goto Block2end

::Block2end::
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:…なんて話してるうちにそろそろアストラット郷に到着ね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_08020053")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_クリスティーナ_ランクアップ8_3")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
