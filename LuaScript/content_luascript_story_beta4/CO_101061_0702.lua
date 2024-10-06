-- このluaスクリプトは、CO_101061_0702.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114042_01","114042_01_h")
Include("content_adv_advsmall_114042_01","Template114042_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114042_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114042_01,CameraPos114042_01_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114042_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleName114042_01,CameraPos114042_01_002)
	InitializeTemplateRandomCamera114042_01()
	InitializeTemplate114042_01()
-- ▼直接出力
prop001 = setup_prop_object(10103001)
off_active(prop001)
prop001_offset = {-0.127,-0.062,0.006,0,0,21.724}

-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
prop002 = setup_prop_object(10103005)
prop002_offset = {-0.015,0.0802,0.033,2.852,-106.577,195.981}
off_active(prop002)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114042)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:古書なんてどこに保管されてるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020002")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力

	--★★ラロゥ★★:ふぅん、初めて来たけど、こうなってるんだ<br>さて、どこから手を付けようか？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020004")

	open_select_window_tag(Actor001,"Normal","CO_101061_07020006","CO_101061_07020007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それじゃあ、手あたり次第見ていくか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:じゃあオレは<br>奥を探してみるよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020010")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん、それらしいものはないな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020012")

-- ▼直接出力
setup_small_camera_end()
PlayPartVoice("ラロゥ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ラロゥ★★:けほっ、けほっ…<br>ちょっと歩くだけで埃まみれだ…
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020014")

	change_face(Actor001,"Normal")

	--★★ノワール★★:大丈夫か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020015")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:平気平気<br>こんなのいつものことだから
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020016")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:しんどくなったら<br>外に空気吸いに行けよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:ん…わかった
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020018")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:じゃあ、俺は奥を見てみるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:わかった<br>オレはこのあたりを調べとく
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020021")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:けほ、けほ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:奥はどこもかしこも埃だらけだ<br>それらしいものはなかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020024")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラロゥ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:うわ、ちょっと！<br>近寄んないでよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020025")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:聖杯探しって大変だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020027")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:参ったな、成果なしか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:そうでもないかも<br>気になるところを見つけたんだ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020030")


	--★★ラロゥ★★:歩き回ってたとき<br>このあたりだけ床の感触が違った
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020032")

-- ▼直接出力
se_play("SE_ADV_MA_01C109_26_Food_Tray")
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:うわ<br>床の下にも空間があったのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020034")

-- ▼直接出力
CloseTalkWindow()
on_active(prop001)
on_parent(prop001,Actor002, "J_Hand_R", prop001_offset)
wait_time(1.3)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_start()
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:…古文書、見っけ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020035")

	open_select_window_tag(Actor001,"Normal","CO_101061_07020037","CO_101061_07020038")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:さすが盗賊だな！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020040")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:トレジャーハンター<br>って言ってくれてもいいよ？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020041")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:これくらい朝飯前さ<br>埃まみれになる前に見つかればよかったけど
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020042")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:結果オーライとしておこう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020043")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん、まったく気が付かなかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020045")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:オレが気付けたからいいじゃん<br>チームってそういうもんでしょ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020047")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:はは、ありがとな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020048")

	goto Block2end

::Block2end::
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:それで、なにが書いてあるんだ？<br>
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020050")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
PlayActionDirect(Actor002,"to EatIdle")
se_play("SE_ADV_MA_01105_13_Book_Page_Slide")
off_active(prop001)
on_active(prop002)
on_parent(prop002,Actor002, "J_Hand_R", prop002_offset)
off_parent(prop001,Actor002, "J_Hand_R", prop001_offset)
SkipDefaultMotion(Actor002)
PlayAction(Actor002,"to EatIdle")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラロゥ", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:うわ、これ古代文字…？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020052")

-- ▼直接出力
 --setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:学園で勉強したから<br>もうスラスラ読めるんだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020053")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ラロゥ★★:いや…これ、見たことない文字だな
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020054")

-- ▼直接出力
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.2)
on_active(prop001)
off_active(prop002)
off_parent(prop002,Actor002, "J_Hand_R", prop002_offset)
on_parent(prop001,Actor002, "J_Hand_R", prop001_offset)
wait_time(0.1)
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:オレが勉強したやつより古い文字かも知れない<br>ちょっと読むのに時間がほしいね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020055")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:わかった<br>この文献を貸してもらえるよう、頼んでくる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020056")

-- ▼直接出力
PlayPartVoice("ラロゥ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:え？こんなの<br>黙って持ってっちゃえばいいじゃん
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020057")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera001)
end
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:言ったろ？<br>他人から物を盗んだらダメだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_07020058")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor001)
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
PlayPartVoice("ラロゥ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:やれやれ<br>騎士ってメンドクサイね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_07020060")

-- ▼直接出力
local trustParam = set_communication_rankup("ラロゥ_コミュランク", "ラロゥ_親密度")
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
setup_prop_object_preload(10103001)
prop001_offset = {-0.127,-0.062,0.006,0,0,21.724}
setup_prop_object_preload(10103005)
prop002_offset = {-0.015,0.0802,0.033,2.852,-106.577,195.981}
	InitializeLoad_Preload()
	load_area_scene_preload(114042)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114042_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
