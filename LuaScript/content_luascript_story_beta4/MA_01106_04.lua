-- このluaスクリプトは、MA_01106_04.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",-5,CharaPosDuelCommonFormation01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPosDuelCommonFormation01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_014_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_006)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002, 0.8,0,0.5,0,10)
keep_ik_lookat(Actor002, Actor001, "J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101060011)
	Actor001 = InitializeCharacter_3D("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","003","101012003","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101050","001","101050001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Sad")

	--★★ディナタン★★:また、傷だらけ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_040002")

	PlayAction(Actor003,"to  Std_Worry")

	--★★ブライアン将軍★★:どうしたって目立っちまうな
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_040003")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Smile")

	--★★ノワール★★:ブライアンがデカいからだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_040005")

	change_face(Actor003,"Smile")

	--★★ブライアン将軍★★:おめえが金キラだからだろ
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_040007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:<ruby=これ>金コート</ruby>じゃなきゃ<br>迎えに来てくれないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_040009")


	--★★ブライアン将軍★★:似合ってねえんだよ タッパは少し伸びたがよ
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_040011")

-- ▼直接出力
DontChangeRandomCamera(true)
on_camera(RndCamera001)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
change_face(Actor001,"Anger")
change_face(Actor003,"Normal")
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ディナタン★★:私…仕立て直す？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_040013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:ありがとうディナタン<br>でも──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_040014")

	change_face(Actor003,"Normal")

	--★★ブライアン将軍★★:それじゃ意味ねえんだよな？<br>親父さんみてえにならなきゃなんねえんだから
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_040015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:………そっ、か そうだよね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_040016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:…どうすれば 似合うようになるかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_040018")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Smile")

	--★★ブライアン将軍★★:「仲間を皆助ける」とか 「世界平和を叶える」とか
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_040019")

	change_face(Actor003,"Normal")

	--★★ブライアン将軍★★:デカくてカッコイイ目標を口に出してりゃあ 自然とカラダがついてくる
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_040020")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:そういうものかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_040021")

-- ▼直接出力
setup_small_camera_end()
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ブライアン将軍★★:そーゆーもんだって
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_040022")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★ディナタン★★:わ、私は、私には なにができるかな…ブライアンさん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_040023")

	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ブライアン将軍★★:歌ってくれよ
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_040024")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:うた…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_040025")


	--★★ブライアン将軍★★:いつものあの やさしい歌
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_040026")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:…それしか、できないのかな
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_040027")


	--★★ブライアン将軍★★:それができるやつが なかなかいねえんだよ
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_040028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ブライアン将軍★★:戦場で気を張ったまんま 戻ってこれねえヤツが大勢いる
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_040030")

	PlayAction(Actor003,"to  Std_Sad01")

	--★★ブライアン将軍★★:心がぶっ壊れちまう いつもの日常に戻れねえまま
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_040031")


	--★★ブライアン将軍★★:身体の傷以上に深刻なんだよそういうのは
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_040032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Normal")

	--★★ブライアン将軍★★:ディナタン、おめえの歌は 俺たちをいつもに戻してくれる
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_040033")


	--★★ブライアン将軍★★:だからいいんだよ
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_040035")

	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★ディナタン★★:うん…、うんっ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01106_040036")

-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
	change_face(Actor003,"Smile")

	--★★ブライアン将軍★★:いつも ノワールのそばにいてやってくれや
	Talk(Actor003,"CHRNAME_BRIAN","speech","L","MA_01106_040037")

-- ▼直接出力
setup_small_camera_end()
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
	InitializeCharacter_3D_Preload("101009","003","101009003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","003","101012003","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101050","001","101050001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
