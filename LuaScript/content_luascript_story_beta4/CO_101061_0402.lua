-- このluaスクリプトは、CO_101061_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_01","110061_01_h")
Include("content_adv_advsmall_110061_01","Template110061_01_h")
Include("content_adv_advsmall_110061_02","110061_02_h")
Include("content_adv_advsmall_110061_02","Template110061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_011_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110061_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName110061_01,CameraPos110061_01_004)
	InitializeTemplateRandomCamera110061_01()
	InitializeTemplate110061_01()
-- ▼直接出力
prop001 = setup_prop_object(10103005)
set_pos(prop001 , {3.363,0.814,10.385})
prop002 = setup_prop_object(10103005)
set_pos(prop002 , {2.959,0.814,10.385})
PlayActionDirect(Actor001,"to  Std_Talk")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor003,"J_Head")
keep_ik_lookat(Actor002,Actor003,"J_Head")
keep_ik_lookat(Actor003,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_mcfc_SitController","to Sit01_Loop",CameraAssetBundleName110061_02,CameraPos110061_02_001)
	InitializeTemplateRandomCamera110061_02()
	InitializeTemplate110061_02()
-- ▼直接出力
SetOffset(Actor002,0,-0.1,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:…ということなんだけど<br>大丈夫かな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04020002")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クリスティーナ★★:ノワールちゃんの頼みならオールオッケーよ<br>ごゆっくりどうぞ♪
	Talk(Actor003,"CHRNAME_CHRISTINA","speech","L","CO_101061_04020003")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
template2()
setup_small_camera_start()
keep_ik_lookat(Actor001,Actor002,"J_Head")
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:それで<br>どんな本に興味があるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04020005")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力

	--★★ラロゥ★★:んー…混じりけのない黄金でできており<br>入れた水を飲めばどんな病でも治るという…
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020007")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ラロゥ★★:えーと、こっちは…<br>手にした者に無窮の喜びを与える…か
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020008")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:熱中してるな<br>そんなに面白い本なのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04020009")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:うわ、その本<br>全部古代文字で書かれてるじゃないか！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04020011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラロゥ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:あ、ノワール<br>いつの間にそこに
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020012")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:その本…<br>聖杯伝説に、関する、説話集…か
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04020014")

-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:へえ<br>ノワールも古代文字が読めるんだ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:授業で習ったんだ<br>ほんの少しだけな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04020017")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:オレと一緒だね<br>まぁ、オレはもうスラスラ読めるけど
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020018")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:オレに学園のことをやたら聞いてきたのは<br>このためか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04020019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:ぶっちゃけると、そうだね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:もしかして、お前も聖杯を探してるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04020021")

-- ▼直接出力
PlayPartVoice("ラロゥ", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:お前「も」…？
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:円卓の騎士も聖杯を探してるわけか<br>いいじゃん、燃えてきたよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020024")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:オレはもともと<br>聖杯を探しにこの街まで来たんだ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ラロゥ★★:でさ、聖杯について調べていたら<br>面白い話がたくさん出てきて
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力

	--★★ラロゥ★★:気づいたら夢中になってた
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020027")


	--★★ラロゥ★★:でも、聖杯に関する書物は<br>古代文字で書かれてることが多くてさ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020028")


	--★★ラロゥ★★:古代文字を読めるようになりたかったんだ<br>それには学園がうってつけかなと思って
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020029")

	open_select_window_tag(Actor001,"Normal","CO_101061_04020031","CO_101061_04020032")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ずいぶんと聖杯に入れ込んでるな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04020034")

-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:誰も手に入れたことのない<br>誰も真実を知らない伝説のお宝
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:聞いただけでワクワクしてくるね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020036")

	change_face(Actor002,"Smile")

	--★★ラロゥ★★:おまけに思わぬ競合相手も見つかったし<br>俄然燃えて来たよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020038")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:動機はあまり良くないかもしれないけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04020040")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:なにかを知りたいと思って<br>実際に勉強するのは感心する。立派だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04020041")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラロゥ", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:普通に探しても見つからないのは<br>わかりきってるからね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020042")

	change_face(Actor002,"Normal")

	--★★ラロゥ★★:他人より先に行くためには<br>努力を惜しんでられないでしょ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020043")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:動機はあまり良くないかもしれないけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04020044")

-- ▼直接出力
PlayPartVoice("ラロゥ", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ラロゥ★★:いちいちうるさいよ
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020045")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ラロゥ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラロゥ★★:ともかく<br>どっちが早く見つけられるか勝負だね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020047")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:勝負？<br>勝負か…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04020049")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:なぁ、ラロゥ<br>ひとつ相談がある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101061_04020050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラロゥ", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:なんだよ、あらたまって？<br>内容にもよるけど…
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020051")

	change_face(Actor002,"Surprise")

	--★★ラロゥ★★:…あ、ごめん！<br>今日これから用事があるんだった
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020052")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ラロゥ★★:また今度話を聞くよ<br>それじゃあね
	Talk(Actor002,"CHRNAME_LAROU","speech","L","CO_101061_04020053")

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
setup_prop_object_preload(10103005)
setup_prop_object_preload(10103005)
	InitializeLoad_Preload()
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101061","001","101061001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_01)
	system.PreLoadRequest(CameraAssetBundleName110061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
