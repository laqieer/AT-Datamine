-- このluaスクリプトは、MA_01C110_35.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_003)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
load_image("10101015", "content_still_10101015_image", "101010150_StillImage") 
load_image("10101015_2", "content_still_10101015_image", "101010150_StillImage") 
-- ▲直接出力
-- ▼直接出力
stillAnime = load_ui_effect("content_still_10103005_anim", "10103005_StillAnim", nil, nil, nil, "Root")
-- ▲直接出力
-- ▼直接出力
show_image("10101015", 0.0, 0.0, 0 )
-- ▲直接出力
-- ▼直接出力
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
hotdog = setup_prop_object(10102001)
off_active(hotdog)
hotdog2 = setup_prop_object(10102001)
off_active(hotdog2)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
set_common_look_at(Actor001,Actor002)
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
fadeout(255, 255, 255, 0, 0.5)
wait_time(0.5)
	stillAnime.SetActive(true)
hide_image(0)
	fadein(0.5)
	local signal = play_ui_timeline_controller_in(stillAnime)
	while signal.IsProccessing() do
		coroutine.yield()
	end
-- ▲直接出力
-- ▼直接出力
wait_time(3.0)
-- ▲直接出力
-- ▼直接出力
signal = play_ui_timeline_controller_out(stillAnime, true)
	while signal.IsProccessing() do
		coroutine.yield()
	end

-- ▲直接出力
-- ▼直接出力
fadeout(255, 255, 255, 0, STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
stillAnime.SetActive(false)
show_image("101010150", 0.0, 0.0, 0.0,false,false)
set_scale_image(20,20)
-- ▲直接出力
-- ▼直接出力
 --ホットドック対応
on_active(hotdog)
on_active(hotdog2)
hotdog_offset = {0,0,0,0,0,0}
on_parent(hotdog,Actor001, "Loc_weapon_constrint_R", hotdog_offset)
hotdog2_offset = {0,0,0,0,0,0}
on_parent(hotdog2,Actor002, "Loc_weapon_constrint_R", hotdog2_offset)
PlayActionDirect(Actor001,"to EatIdle")
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor002,"to EatIdle")
SkipDefaultMotion(Actor002)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
fadein(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:ディナタン！ほら、こっちこっち！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C110_350002")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:ほら、これ！美味しいのよ！　<br>わたしのおすすめ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C110_350003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:ソースがつかないように食べるの<br>ちょっとコツがいるの。こうやって…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C110_350004")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera001)
wait_time(1.0)
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor001,"Surprise")

	--★★ギネヴィア★★:きゃあぁっ、ソース出てきたっ<br>ちょ、制服についた～っ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","N","MA_01C110_350006")

	close_cutin()

	--★★ギネヴィア★★:ディナタンは平気！？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C110_350007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定3")
-- ▲直接出力

	--★★ディナタン★★:うん！すごくおいしい！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_350008")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力

	--★★ギネヴィア★★:ソース一滴もこぼしてない！<br>嘘！？天才なの！？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C110_350009")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:天才！？<br>お、大袈裟ですよ…ふふっ
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_350010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:やっと笑った
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C110_350011")

-- ▼直接出力
 --PlayPartVoice("ディナタン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ディナタン★★:え…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_350012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:学園に戻ってきてから<br>全然笑ってくれないだもん
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C110_350013")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:あ…
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_350014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:まぁ…その気持ちもわかるけどね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C110_350015")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:でもせっかくの学園祭なんだから<br>楽しまないと
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C110_350016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:楽しい思い出があれば<br>明日からもきっと頑張れるわ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C110_350017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ディナタン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ディナタン★★:…はい
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01C110_350018")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:そうと決まれば、さっそく次よ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C110_350019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:ほら、見て！<br>ほかにもいろんなお店が出てるの
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C110_350020")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:ステージまで時間があるし<br>ふたりで全部回りましょ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01C110_350021")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10101015", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("10101015_2", "content_still_10101015_image", "101010150_StillImage")
load_ui_effect_preload("content_still_10103005_anim", "10103005_StillAnim", nil, nil, nil, "Root")
setup_prop_object_preload(10102001)
setup_prop_object_preload(10102001)
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
