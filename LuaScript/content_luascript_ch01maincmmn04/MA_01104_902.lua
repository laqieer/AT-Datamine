-- このluaスクリプトは、MA_01104_902.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",30,CharaPos112041_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_03_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_005)
	InitializeTemplateRandomCamera112041_03()
	InitializeTemplate112041_03()
-- ▼直接出力
Hide(Actor002)
set_pos(Actor002,{1.595, 0, 4.811})
-- ▲直接出力
-- ▼直接出力
sakabin = setup_prop_object(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
on_parent(sakabin ,Actor003, "Loc_weapon_constrint_R", sakabin_offset2 )
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★酒場店主★★:いらっしゃい<br>どなたかをおさがしですか？
	Talk(Actor003,"NPCNAME_0085","speech","L","MA_01104_9020002")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:憲兵団の任務の件で<br>ここにいる情報屋に話を聞けと言われまして
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9020003")

-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
on_camera(Camera001)
-- ▲直接出力

	--★★酒場店主★★:ああ、それならそちらに
	Talk(Actor003,"NPCNAME_0085","speech","L","MA_01104_9020004")

-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
Appear(Actor002)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
-- ▼直接出力
turn(Actor001,0,0,0,0.2)
-- ▲直接出力
-- ▼直接出力
character_in_move_walk(Actor002,CharaPos003,1.8,0)
-- ▲直接出力

	--★★キッス★★:アタシをおさがしかしら？
	Talk(Actor002,"NPCNAME_0306","speech","L","MA_01104_9020005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★キッス★★:キミ、学生さんでしょ？<br>憲兵団は軍の兵隊さんしかいないはずだけど
	Talk(Actor002,"NPCNAME_0306","speech","L","MA_01104_9020006")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:見習いとしてなら構わない、って言われてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9020007")

	change_face(Actor002,"Normal")

	--★★キッス★★:ふうん…？でも、お仕事を渡す前に<br>腕前を見てみたいわね
	Talk(Actor002,"NPCNAME_0306","speech","L","MA_01104_9020008")


	--★★キッス★★:これから〇日後に、付近を見回って<br>バルバロイを掃討するという作戦があるの
	Talk(Actor002,"NPCNAME_0306","speech","L","MA_01104_9020009")

	PlayAction(Actor002,"to  Std_Talk")

	--★★キッス★★:少し人手が足りないってことだから<br>それに参加してバルバロイを倒してきて
	Talk(Actor002,"NPCNAME_0306","speech","L","MA_01104_9020010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:わかった、〇日後だな<br>行って来るよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9020011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:よろしくね<br>ラビットちゃん♪
	Talk(Actor002,"NPCNAME_0306","speech","L","MA_01104_9020012")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ラ、ラビットちゃん…？<br>（俺のことか…？？）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9020013")

-- ▼直接出力
--キッス,CHRNAME_KISS @名前変更
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")

	--★★キッス★★:それから…アタシの名前はキッス<br>『エージェント・キッス』って呼んでちょうだい
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01104_9020014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:あ、ああ…よろしく、キッスさん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_9020015")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
