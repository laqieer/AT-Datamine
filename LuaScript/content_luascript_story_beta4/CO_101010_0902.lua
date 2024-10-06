-- このluaスクリプトは、CO_101010_0902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:それにしてもふたりでいろんな場所を巡ったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:俺が受け継いだ師匠の思い出の地も残りわずかだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:こうして学園を離れてふたりでいるとまるで昔に戻った気分になる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09020004")

-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ランスロット★★:教師なんて本当はガラじゃないんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09020006")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうなのか？その割にはスパルタ指導が板についてるけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09020007")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ランスロット", "怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:冗談だろう？最初はお前も似合わないと言っていたじゃないか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09020008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101010_09020010","CO_101010_09020011")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうだっけ？よく覚えてないな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09020013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:やれやれ昔からお前は都合の悪いことはすぐ忘れる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09020014")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:剣術以外について講義している姿は未だに違和感があるけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09020015")

-- ▼直接出力
PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:こいつ…覚えているじゃないか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09020016")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははっ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09020017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それは、その…当てつけってやつだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09020019")

-- ▼直接出力
PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:当てつけ？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09020020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あのときはあんたが信用できなかったというか…正直言うと腹が立ってた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09020021")

	change_face(Actor001,"Normal")

	--★★ノワール★★:大事なことをなにも教えてくれないのに言うに事を欠いて先生だなんて、ってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09020023")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:そうか…しかし、そう思われて当然だな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09020024")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:俺はお前になにも言ってやることができなかったのだから
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09020025")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:信用したいけど、信用できない…そんな気持ちの表れだった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09020026")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:今思えば、甘ったれでダサいよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09020027")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:…いいや。そんなことないさ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09020029")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
change_face(Actor002,"Sad")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いろいろ落ち着いたらさしばらくリムニーナ村に戻らないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09020031")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ディナタンも誘ってさ置いてったらきっと拗ねるだろうし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09020032")


	--★★ノワール★★:子どもの頃みたいに３人で湖のほとりで遊ぶんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09020033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力

	--★★ノワール★★:きっと楽しいだろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09020034")

-- ▼直接出力
CloseTalkWindow()
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
wait_time(1.2)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:そうだな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09020036")

-- ▼直接出力
reserve_next_script("1章/コミュ/x0401_ランスロット_ランクアップ9_3")
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
	load_duel_scene_preload(101060011)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
