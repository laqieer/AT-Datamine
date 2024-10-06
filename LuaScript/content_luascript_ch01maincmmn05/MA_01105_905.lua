-- このluaスクリプトは、MA_01105_905.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_001)
	Camera002 = SetTemplate("Actor002",-10,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	Camera005 = SetTemplate("Actor005",-100,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera006 = SetTemplate("Actor006",-55,CharaPosDuelCommonFormation01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_004)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
lookat_delay_weight(Actor002, 0.7, 0.03, 0.7, 0.5,1.0)
lookobj = create_object("kara")
set_pos_object(lookobj,0.283,1.482,-0.386)
keep_ik_lookat_object(Actor002,nil,"kara") 
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000022)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:どーう？<br>ざっとこんなもんよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_9050002")

-- ▼直接出力
PlayActionDirect(Actor005,"to  Std_Talk")
turn_chara(Actor005,-120,0.5)
-- ▲直接出力

	--★★ギネマウア★★:殿下、スカートの裾に泥が跳ねております<br>こちらを使ってお拭きください
	Talk(Actor005,"NPCNAME_0070","speech","L","MA_01105_9050003")


	--★★ギネマウア★★:それとも代わりの服にお着替えなさいますか？
	Talk(Actor005,"NPCNAME_0070","speech","L","MA_01105_9050004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:いらないわ<br>キャメリアード城、もうすぐそこだし
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_9050005")

	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…なんか思い出しちゃった
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_9050006")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:ちっちゃいとき<br>雨のなか、外に飛び出して行って
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_9050007")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:服を泥だらけにしてお城に帰ったら<br>お姉ちゃんにすっごく叱られたなあ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_9050008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:厳しいお姉さんだったんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_9050009")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:うーん…？<br>そうね、わたしにすごく厳しくて、怖かった
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_9050010")


	--★★ギネマウア★★:厳しくしたのは<br>お姉様の愛情表現だったのではないでしょうか
	Talk(Actor005,"NPCNAME_0070","speech","L","MA_01105_9050011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:そうかなあ？<br>ほんとにそう思う？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_9050012")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
	change_face(Actor005,"Smile")

	--★★ギネマウア★★:そうですよ、きっと
	Talk(Actor005,"NPCNAME_0070","speech","L","MA_01105_9050013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:じゃ、そういうことにしときましょ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_9050014")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_9050015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:なによノワール<br>こっちをじっと見て…あっ！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_9050016")

-- ▼直接出力
lookat_delay_weight_reset(Actor002,1)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to  Std_Sad01")
turn_chara(Actor002,-50,1.0)
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:もしかして<br>雨に濡れて透けて見えてる！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_9050017")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
turn_chara(Actor005,-60,1.0)
turn_chara(Actor006,-40,0)
lookat_delay_weight(Actor005, 0.8, 0.03, 0.7, 0.5,1.0)
lookat_delay_weight(Actor006, 1.0, 0.03, 0.7, 0.5,1.0)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1)
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",1)
keep_delay_ik_lookat(Actor005,Actor001,"J_Head",1)
keep_delay_ik_lookat(Actor006,Actor001,"J_Head",1)
change_face(Actor005,"Surprise")
change_face(Actor006,"Surprise")
-- ▲直接出力

	--★★ノワール★★:違う！<br>違う違う、誤解だ！濡れ衣だ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_9050018")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
	change_face(Actor004,"Surprise")

	--★★ガウェイン★★:うわー<br>ノワール、お前最低だな…
	Talk(Actor004,"CHRNAME_GAWAIN","speech","L","MA_01105_9050019")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Anger")

	--★★ラグネル★★:女の敵よ、敵
	Talk(Actor003,"CHRNAME_RAGNAR","speech","L","MA_01105_9050020")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Sad")

	--★★ノワール★★:違うんだって！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01105_9050021")

	change_face(Actor006,"Anger")

	--★★ティルフィング★★:…
	Talk(Actor006,"CHRNAME_TYRFING","speech","L","MA_01105_9050022")

-- ▼直接出力
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor002)
set_enable_auto_lookat_all(true)
turn_chara(Actor005,-120,1.5)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
turn_chara(Actor002,0,0.5)
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:にししっ♪<br>冗談はこのへんにして、先に進みましょ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01105_9050023")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_duel_scene_preload(101000022)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
