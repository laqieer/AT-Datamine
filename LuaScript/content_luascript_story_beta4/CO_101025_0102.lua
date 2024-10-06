-- このluaスクリプトは、CO_101025_0102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera006 = SetTemplate("Actor006",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera007 = SetTemplate("Actor007",nil,CharaPos110111_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Npc_1002_01_Controller","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_008)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
DontChangeRandomCamera(true)
set_pos(Actor003,{-4.7,0,1.8})
set_rot(Actor003,{0,110,0})
set_pos(Actor007,{-1.3,0,0.9})
set_rot(Actor007,{0,40,0})
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401015","001","401015001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401017","001","401017001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401016","001","401016001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("402001","001","402001001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:はい、見つけてきたわよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01020002")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
PlayPartVoice("子供_男1", "納得")
-- ▲直接出力

	--★★子供（男）★★:わー、スコーンだ！<br>どこ行ってたんだよ、おまえ！
	Talk(Actor004,"NPCNAME_0140","speech","N","CO_101025_01020003")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:はは<br>美味しそうな名前がつけられてるんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01020004")

-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:ここの子たち<br>みんなで世話してるんだって
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01020005")

	PlayAction(Actor005,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("子供_男2", "挨拶")
-- ▲直接出力

	--★★子供（男）②★★:あのね、クレアおねえちゃん…<br>ジョーイもぼくもお金なくって…だから…
	Talk(Actor005,"NPCNAME_0141","speech","N","CO_101025_01020007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
--子供（男）,NPCNAME_0244 @名前変更
change_face(Actor001,"Normal")
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:報酬ならもう受け取ってるわよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01020008")

-- ▼直接出力
setup_small_camera_start(Camera002)
set_enable_auto_lookat_all(true)
-- ▲直接出力

	--★★クレア★★:わたしの好奇心を満たしてくれた<br>それだけで十分よ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01020009")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("子供_男1", "納得")
-- ▲直接出力

	--★★子供（男）★★:ありがとう、クレアおねえちゃん！<br>じょしゅのおにいちゃんも！
	Talk(Actor004,"NPCNAME_0244","speech","N","CO_101025_01020011")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to Run")
turn_chara(Actor004,0,0.3)
slidemove(Actor004,{-1,0,4.5},1)
wait_time(0.5)
PlayActionDirect(Actor006,"to Run")
turn_chara(Actor006,0,0.3)
slidemove(Actor006,{-1.4,0,5.2},1)
wait_time(0.2)
PlayActionDirect(Actor005,"to Run")
turn_chara(Actor005,0,0.3)
slidemove(Actor005,{-0.9,0,3.5},1)
wait_time(0.2)
PlayActionDirect(Actor007,"to Run")
turn_chara(Actor007,0,0.3)
slidemove(Actor007,{-1.4,0,4},1)
wait_time(1.5)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101025_01020013","CO_101025_01020014","CO_101025_01020015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
PlayActionDirect(Actor001,"to  Std_Talk")
set_common_look_at(Actor001,Actor002)
set_pos(Actor002,{-1.7,0,0.1})
set_rot(Actor002,{0,-30,0})
set_enable_auto_lookat_all(true)
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:優しいんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01020017")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:そうかしら<br>善良な大人なら子供からお金はとらないわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01020018")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:はは、お金のことじゃなくてさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01020019")

-- ▼直接出力
PlayPartVoice("クレア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クレア★★:どういうこと？<br>謎かけかしら
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01020021")

-- ▼直接出力
change_face(Actor001,"Normal")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クレア★★:…不思議な人ね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01020022")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
PlayActionDirect(Actor001,"to  Std_Talk")
set_common_look_at(Actor001,Actor002)
set_pos(Actor002,{-1.7,0,0.1})
set_rot(Actor002,{0,-30,0})
set_enable_auto_lookat_all(true)
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:犬探しで好奇心が満たされるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01020024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:ここのところ多いのよ<br>迷い犬を探してくれという依頼が
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01020025")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:へえ<br>どうしてまた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01020026")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
change_face(Actor001,"Normal")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:どうしてかしらね<br>それを知るにはまだ材料が足りないわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01020028")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
PlayActionDirect(Actor001,"to  Std_Talk")
set_common_look_at(Actor001,Actor002)
set_pos(Actor002,{-1.7,0,0.1})
set_rot(Actor002,{0,-30,0})
set_enable_auto_lookat_all(true)
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:役に立ててよかったよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01020030")

-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:おおよその見当はつけていたのだけれど<br>ノワールのおかげで居場所を特定できたわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01020031")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうなのか<br>だからあの場所にいたんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01020032")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クレア", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:…ねえ、ノワール
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01020034")


	--★★クレア★★:ときどきでいいのだけれど<br>探偵業の助手をしてくれないかしら
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01020035")

-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor003)
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ、なんで俺？<br>ヴォールスがいるだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01020036")

-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("ヴォールス", "挨拶")
-- ▲直接出力

	--★★ヴォールス★★:自分は助手じゃない<br>クレアが勝手にそう言っているだけだ
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_01020038")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera002)
set_common_look_at(Actor001,Actor003)
set_common_look_at(Actor002,Actor003)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,{-3,0,1.6},1)
wait_time(0.8)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")

	--★★クレア★★:ヴォールスは<br>動物と子供に警戒されてしまうから
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01020040")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ヴォールス", "怒り")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ヴォールス★★:む…<br>誰にでも向き不向きというものがあるだろう
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_01020041")

-- ▼直接出力
set_enable_auto_lookat_all(true)
-- ▲直接出力

	--★★クレア★★:それに今は依頼がとても多くて<br>猫の手も借りたいところなの
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01020042")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:お、俺は猫なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01020043")

-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:犬がいい？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01020044")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そういう問題じゃなくてさ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01020045")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "肯定2")
-- ▲直接出力

	--★★クレア★★:なんにしても<br>ノワールが協力してくれたら心強いわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01020046")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺に務まるかわからないけど<br>手が空いてるときでよければ手伝うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_01020047")

	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:ありがとう<br>クレア探偵事務所で待ってるわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_01020048")

-- ▼直接出力
local trustParam = set_communication_acquired("クレア_コミュランク", "クレア_親密度")
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
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
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401015","001","401015001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401017","001","401017001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401016","001","401016001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("402001","001","402001001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
