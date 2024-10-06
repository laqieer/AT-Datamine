-- このluaスクリプトは、MA_01A109_27.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111013_05","111013_05_h")
Include("content_adv_advsmall_111013_05","Template111013_05_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111013_05_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111013_05,CameraPos111013_05_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111013_05_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_019_01_StdController","to Std_Loop",CameraAssetBundleName111013_05,CameraPos111013_05_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111013_05_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111013_05,CameraPos111013_05_003)
	InitializeTemplateRandomCamera111013_05()
	InitializeTemplate111013_05()
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
set_common_look_at(Actor002,Actor003,1)
-- ▲直接出力
-- ▼直接出力
mob1   = setup_prop_object(10130011)
set_pos(mob1,{1,0,-6})
set_rot(mob1,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob2   = setup_prop_object(10130011)
set_pos(mob2,{3,0,-6})
set_rot(mob2,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob3   = setup_prop_object(10130011)
set_pos(mob3,{-1,0,-6})
set_rot(mob3,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob4   = setup_prop_object(10130011)
set_pos(mob4,{-3,0,-6})
set_rot(mob4,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob5   = setup_prop_object(10130010)
set_pos(mob5,{1,0,-4})
set_rot(mob5,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob6   = setup_prop_object(10130010)
set_pos(mob6,{3,0,-4})
set_rot(mob6,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob7   = setup_prop_object(10130010)
set_pos(mob7,{-1,0,-4})
set_rot(mob7,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob8   = setup_prop_object(10130010)
set_pos(mob8,{-3,0,-4})
set_rot(mob8,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob9   = setup_prop_object(10130010)
set_pos(mob9,{1,0,-2})
set_rot(mob9,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob10 = setup_prop_object(10130010)
set_pos(mob10,{3,0,-2})
set_rot(mob10,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob11 = setup_prop_object(10130010)
set_pos(mob11,{-1,0,-2})
set_rot(mob11,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob12 = setup_prop_object(10130010)
set_pos(mob12,{-3,0,-2})
set_rot(mob12,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob13 = setup_prop_object(10130010)
set_pos(mob13,{1,0,0})
set_rot(mob13,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob14 = setup_prop_object(10130010)
set_pos(mob14,{3,0,0})
set_rot(mob14,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob15 = setup_prop_object(10130010)
set_pos(mob15,{-1,0,0})
set_rot(mob15,{0,180,0})
-- ▲直接出力
-- ▼直接出力
mob16 = setup_prop_object(10130010)
set_pos(mob16,{-3,0,0})
set_rot(mob16,{0,180,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111013)
	Actor001 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
DontChangeRandomCamera(true)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ルーシャス★★:魔女よ<br>バルバロイに喰い尽くされた者はどうなるか
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_270002")

	PlayAction(Actor003,"to  Std_Joy")
	change_face(Actor003,"Smile")

	--★★モーロノエー★★:誰の記憶からも消え去り、忘れ去られるわ<br>その存在自体が歴史から抹消される♪
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01A109_270004")


	--★★ルーシャス★★:そう。ユーサーはそれすら利用した
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_270005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:ログレスにいたローマ人の存在は<br>ひとり残らず歴史の上から抹消された
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_270006")


	--★★ルーシャス★★:本当のことを知る者は消え<br>ユーサーは対バルバロイの英雄として君臨
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_270007")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力

	--★★ルーシャス★★:なに食わぬ顔でローマ本国と友好を結ぶのも<br>容易であったろうな
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_270008")


	--★★ルーシャス★★:本当のことを知る者がひとりもいなければ<br>ユーサーの暴虐を覚えている者がいなければ
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_270009")

-- ▼直接出力
CloseTalkWindow()
set_pos(Actor001,{-0.05, 1.052, -17.04})
set_animationcontroller(Actor001,"Chr_020_01_StdController","to Std_Loop")
lookat_delay_weight_reset(Actor002,1.0)
wait_time(1.0)
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Anger")

	--★★ルーシャス★★:だが余は覚えているぞ、皆の者！！
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_270012")


	--★★ルーシャス★★:世に知らしめてやるのだ！！
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_270013")

	PlayAction(Actor001,"to  Std_Angry")

	--★★ルーシャス★★:ログレスが行った虐殺がどれだけ凄惨であったか<br>ロンディニウムを見れば嫌でも忘れまい！！
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_270014")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力

	--★★ルーシャス★★:罪なき者の命が抗うすべなく<br>ログレスに奪われた記憶を刻め！
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_270015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ルーシャス★★:ロンディニウムで殺された者たちは殉教者だ<br>ローマの無念を晴らすべく身を捧げた名誉ある民
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_270016")


	--★★ルーシャス★★:またいつログレスが牙をむくか…<br>いついつバルバロイが襲い来るか…
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_270017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ルーシャス★★:震えて眠れぬ日々からの解放！
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_270018")


	--★★ルーシャス★★:余はここに復古することを宣言する！<br>全ての道が余に通づる──
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_270019")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
	change_face(Actor001,"Normal")

	--★★ルーシャス★★:『ローマによる平和』を！
	Talk(Actor001,"CHRNAME_LUCIUS","speech","L","MA_01A109_270020")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10130011)
setup_prop_object_preload(10130011)
setup_prop_object_preload(10130011)
setup_prop_object_preload(10130011)
setup_prop_object_preload(10130010)
setup_prop_object_preload(10130010)
setup_prop_object_preload(10130010)
setup_prop_object_preload(10130010)
setup_prop_object_preload(10130010)
setup_prop_object_preload(10130010)
setup_prop_object_preload(10130010)
setup_prop_object_preload(10130010)
setup_prop_object_preload(10130010)
setup_prop_object_preload(10130010)
setup_prop_object_preload(10130010)
setup_prop_object_preload(10130010)
	InitializeLoad_Preload()
	load_area_scene_preload(111013)
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101052","001","101052001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111013_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
