-- このluaスクリプトは、EA_003_041.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_04","110011_04_h")
Include("content_adv_advsmall_110011_04","Template110011_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110011_04_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_04_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110011_04,CameraPos110011_04_006)
	InitializeTemplateRandomCamera110011_04()
	InitializeTemplate110011_04()
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
load_image("104000180", "content_still_10400018_image", "104000180_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("104000190", "content_still_10400019_image", "104000190_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ギネヴィア","挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:ねえ、ノワール<br>この３つのデザインだったらどれがいい？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0410002")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.2)
PlayActionDirect(Actor002,"to LookFor")
wait_time(1.0)
setup_small_camera_start(RndCamera005)
wait_time(0.6)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to Show")
wait_time(0.7)
ShowImageItem("104000180")
wait_time(0.3)
-- ▲直接出力

	--★★ノワール★★:どれって…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0410004")

-- ▼直接出力
HideImageItem()
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","EA_003_0410006","EA_003_0410007","EA_003_0410008")
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
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:は！？ちょっと、何言ってんの！？真面目に選んでよ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0411001")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、そもそもこれなんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0411002")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:水着のデザインに決まってるでしょ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0411003")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("ギネヴィア","怒り")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:は！？ちょっと、何言ってんの！？<br>真面目に選んでよ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0410011")

-- ▼直接出力
PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、そもそもこれなんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0410012")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア","驚き")
-- ▲直接出力

	--★★ギネヴィア★★:水着のデザインに決まってるでしょ！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0410013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:水着！？これが！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0410014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネヴィア","肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ギネヴィア★★:そうよ！ティルフィングに似合う水着を<br>わたしなりに考えてデザインしたの！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0410015")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力

	--★★ギネヴィア★★:わたし用にオーダーメイドの<br>水着を頼んでるお店があるから
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0410016")

-- ▼直接出力
PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:そこでお願いしようかなって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0410017")


	--★★ノワール★★:こ、これを店に持っていく気か！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0410018")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア","肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:そうよ。悪い？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0410019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:悪いっていうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0410020")

-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネマウア","挨拶")
-- ▲直接出力
	change_face(Actor003,"Laugh")

	--★★ギネマウア★★:ちなみに私も描いたのですが…
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0410022")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor003,"to LookFor")
wait_time(1.0)
setup_small_camera_start()
wait_time(0.6)
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to Show")
wait_time(0.7)
ShowImageItem("104000190")
set_enable_auto_lookat(Actor002, false)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.8)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0030")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…！！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0410024")

-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:（ギネマウアさんにも苦手なものがあるんだな…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","EA_003_0410026")

-- ▼直接出力
CloseTalkWindow()
HideImageItem()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:…え、ひょっとして<br>これじゃ伝わらない感じ？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0410027")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力

	--★★ノワール★★:まぁ…多分…<br>まずもってまったく水着に見えないし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0410028")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ギネヴィア","悲しみ")
-- ▲直接出力

	--★★ギネヴィア★★:うそ…どうしたらいいの！？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0410029")

-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:ノワール、なんとかして！<br>わたしの傭兵でしょ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0410031")

-- ▼直接出力
PlayPartVoice("ノワール","落胆")
-- ▲直接出力

	--★★ノワール★★:はぁ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0410032")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺が描くから<br>ギネヴィアはイメージを伝えてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0410033")

-- ▼直接出力
 --暗転して時間経過
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME + 0.8)
se_play("SE_ADV_EA_003_041_Draw")
wait_time(4.2)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:――こんな感じでどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0410035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ギネヴィア","喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:わあ…すごい！<br>完璧にわたしのイメージ通りだわ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0410036")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ギネマウア","落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ギネマウア★★:同じものをイメージして描いたはずなのに<br>どうしてこうも違うんでしょう
	Talk(Actor003,"CHRNAME_GWENHWYMAWR","speech","L","EA_003_0410037")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:まぁ、人には向き不向きがあるから…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","EA_003_0410038")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ギネヴィア","笑い")
-- ▲直接出力

	--★★ギネヴィア★★:それじゃ、さっそく発注に行きましょ！
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","EA_003_0410039")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("104000180", "content_still_10400018_image", "104000180_StillImage")
load_image_preload("104000190", "content_still_10400019_image", "104000190_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
