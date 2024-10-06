-- このluaスクリプトは、MA_01C111_10.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",155,CharaPos110061_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_507_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_005)
	Camera002 = SetTemplate("Actor002",-15,CharaPos110061_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_001)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
chair = get_object("geo_chair_12")
set_pos(chair, {4.5,0,10})
set_rot(chair, {0,0,0})
prop001 =setup_prop_object(10103005)
prop001_offset={-0.2,-0.01,0,0,-20,-165}
on_parent(prop001,Actor002, "J_Hand_L", prop001_offset)
on_active(prop001)
prop002 = setup_prop_object(10106001)
set_pos(prop002 ,{3,0.82,10.35})
set_rot(prop002 ,{0,-15,0})
off_active(prop002 )
set_pos(Actor001,{1,0,13.3})
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Reading")
-- ▲直接出力
-- ▼直接出力
set_camera_nearclip(Camera002,1)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookoj=create_object("kara")
set_pos_object(lookoj,3,0.82,10.35)
keep_delay_ik_lookat_object(Actor002,lookoj,"kara",1.0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101017","001","101017001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
slidemove(Actor001,{2.25,0,11.3},1.5)
wait_time(1.3)
PlayActionDirect(Actor001,"to Std_Loop")
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
off_parent(prop001)
off_active(prop001)
on_active(prop002)
PlayActionDirect(Actor002,"to Sit01_Loop")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★マルディサント★★:なんだ、それ<br>今読んでる本か？
	Talk(Actor001,"CHRNAME_MALADISANT","speech","L","MA_01C111_100002")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight(Actor002,0.7,0.03,0.7,0,0.5)
-- ▲直接出力

	--★★ディナタン★★:ううん…私が見た夢の話<br>ひとめでふたりは恋に落ちるの
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_100003")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Talk")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★マルディサント★★:ベタだな～。『まことの恋をする者は<br>皆ひとめで恋に落ちる』かよ
	Talk(Actor001,"CHRNAME_MALADISANT","speech","L","MA_01C111_100004")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ディナタン★★:わかんないけど<br>ふたりっきりのときふたりは幸せそうだった
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_100005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★マルディサント★★:芝居だったらクソだな
	Talk(Actor001,"CHRNAME_MALADISANT","speech","L","MA_01C111_100006")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:でもふたりは離れ離れになる…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_100007")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★マルディサント★★:どっちみちクソだな
	Talk(Actor001,"CHRNAME_MALADISANT","speech","L","MA_01C111_100008")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力

	--★★ディナタン★★:妖精と人間との恋は禁じられてるんだって<br>夢では言ってたけど、どうしてだろ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_100009")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★マルディサント★★:んなの妖精探して聞いてみねえと<br>わかんねーよ
	Talk(Actor001,"CHRNAME_MALADISANT","speech","L","MA_01C111_100010")


	--★★マルディサント★★:禁じられた恋なんてくだらねえ
	Talk(Actor001,"CHRNAME_MALADISANT","speech","L","MA_01C111_100011")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:そうかなぁ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_100012")

	PlayAction(Actor001,"to  Std_Worry")

	--★★マルディサント★★:『まことの恋の道は、茨の道である』なんて<br>バカみたいだ
	Talk(Actor001,"CHRNAME_MALADISANT","speech","L","MA_01C111_100013")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:恋の道は茨かあ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_100014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:禁じられた恋ってどうしてみんなしちゃうのかな
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_100015")


	--★★マルディサント★★:禁じられてるには<br>それなりに理由があんだろ
	Talk(Actor001,"CHRNAME_MALADISANT","speech","L","MA_01C111_100016")


	--★★ディナタン★★:たとえば？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_100017")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Talk")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★マルディサント★★:…たとえば呪われるとか<br>なんなら忌み子が生まれるとか
	Talk(Actor001,"CHRNAME_MALADISANT","speech","L","MA_01C111_100018")

	change_face(Actor002,"Sad")

	--★★ディナタン★★:忌み子…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_100020")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★マルディサント★★:………それから
	Talk(Actor001,"CHRNAME_MALADISANT","speech","L","MA_01C111_100021")


	--★★ディナタン★★:それから？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_100022")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Sad01")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★マルディサント★★:…子供が産まれないとか
	Talk(Actor001,"CHRNAME_MALADISANT","speech","L","MA_01C111_100023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:…子供が産まれないといけないの？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_100025")

	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Anger")

	--★★マルディサント★★:しらねーよ、そんなの！<br>昔の人が決めたんだろ
	Talk(Actor001,"CHRNAME_MALADISANT","speech","L","MA_01C111_100026")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ディナタン★★:別に産まれなくってもいいのにね<br>ふたりが幸せなら?
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C111_100027")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10103005)
prop001_offset={-0.2,-0.01,0,0,-20,-165}
setup_prop_object_preload(10106001)
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101017","001","101017001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
