-- このluaスクリプトは、CO_101061_0207.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_mcfc_SitController","to Sit01_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_002)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
SetOffset(Actor002,0,-0.1,0.14)
-- ▲直接出力
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:今日はサンキュー/学園ってこんな感じだったんだね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_02070002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:通いたくなったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_02070003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:それはないね/オレは今の生活が気に入ってるもん
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_02070004")


	--★★ラロゥ★★:ここがノワールたちの教室？/授業ってどんな感じにやるの？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_02070006")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:えーと/先生がこうやって教壇に立って…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_02070007")


	--★★ノワール★★:講義をしたり板書したりする/生徒たちはそれを聞くんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_02070009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "納得")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:なるほどね/それで大人数が効率よく勉強できるんだ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_02070010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:ってことは/オレが混じって勉強してもいいってこと？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_02070011")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それは難しいかな/入学試験があるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_02070012")

-- ▼直接出力
PlayPartVoice("ラロゥ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラロゥ★★:…あっそ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_02070014")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:やっぱり通いたいんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_02070015")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:違うって/ただのたとえ話だよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_02070016")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:おっと/こんな時間か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_02070018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力

	--★★ラロゥ★★:オレも今日はもう帰ろうかな/お礼は次に会ったときでいい？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_02070019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:気にしなくていいさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_02070020")

-- ▼直接出力
local trustParam = set_communication_rankup("ラロゥ_コミュランク", "ラロゥ_親密度")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
