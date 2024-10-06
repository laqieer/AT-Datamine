-- このluaスクリプトは、CO_101028_0101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_05","110071_05_h")
Include("content_adv_advsmall_110071_05","Template110071_05_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_05_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_006)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_05_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_519_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110071_05_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_516_01_StdController","to Std_Loop",CameraAssetBundleName110071_05,CameraPos110071_05_002)
	InitializeTemplateRandomCamera110071_05()
	InitializeTemplate110071_05()
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
set_common_look_at(Actor003,Actor001)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:ガラハッドにフィエナじゃないかなにしてるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_01010002")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:ノ、ノワール！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_01010004")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フィエナ", "挨拶")
-- ▲直接出力

	--★★フィエナ★★:ノワール、ノワール！ねえ、ちょっと聞いて！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_01010005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
set_enable_auto_lookat(Actor003, true)
-- ▲直接出力

	--★★フィエナ★★:ガラハッドってばまだこの制服に慣れないみたいなの
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_01010006")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:だって、おかしい…<br>こんな布で下半身を防御するなんて
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_01010008")

	change_face(Actor002,"Anger")

	--★★ガラハッド★★:ちょっと風が吹いただけでまくれていたら敵の攻撃が来たときどうするのですか！？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_01010009")

-- ▼直接出力
PlayPartVoice("フィエナ", "否定")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★フィエナ★★:もー…全部の服が戦いを前提に作られてるわけじゃないんだから
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_01010011")

	PlayAction(Actor002,"to  Std_Angry")

	--★★ガラハッド★★:スースーするにも限度がある！これでは裸と変わらない！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_01010012")


	--★★ノワール★★:（変わると思うけど…）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101028_01010013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:それにこんな恰好そもそもガラハッドには似合わない
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_01010014")

	change_face(Actor003,"Normal")

	--★★フィエナ★★:そんなことないよ！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_01010015")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
set_enable_auto_lookat(Actor003, false)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.7)
wait_time(0.2)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.8)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フィエナ", "挨拶")
-- ▲直接出力

	--★★フィエナ★★:ノワールもそう思うでしょ？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_01010016")

	open_select_window_tag(Actor001,"Normal","CO_101028_01010018","CO_101028_01010019","CO_101028_01010020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:かわいいと思うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_01010022")

	change_face(Actor002,"Sad")

	--★★ガラハッド★★:そ、それはこの制服がだろう
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_01010023")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:制服を着てるガラハッドが、だよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_01010024")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:な！？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_01010025")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",0.7)
wait_time(0.2)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.8)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:あ、ガラハッドったら顔真っ赤～♪
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_01010026")

-- ▼直接出力
PlayPartVoice("ガラハッド", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ガラハッド★★:こ、これは…ちょっと暑いだけだ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_01010027")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ、似合ってるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_01010029")

-- ▼直接出力
PlayPartVoice("ガラハッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガラハッド★★:そうかそれならいい、が…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_01010030")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",0.7)
wait_time(0.2)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.8)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フィエナ", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:男の子が言ったらあっさり受け入れるんだぁノワールだから、かな？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_01010031")

	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★ガラハッド★★:こ、これは社交辞令だ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_01010032")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:えっと…ノーコメントで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_01010034")

-- ▼直接出力
PlayPartVoice("ガラハッド", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:やっぱり変なんだ…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_01010036")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フィエナ", "怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★フィエナ★★:照れて言えないくらい似合ってるってことだよ！ね？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_01010037")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？あーそうそう、そういうことだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_01010038")

-- ▼直接出力
PlayPartVoice("ガラハッド", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガラハッド★★:そうなのか…？
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_01010039")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.8)
wait_time(0.2)
-- ▲直接出力
	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ガラハッド★★:姉上とノワールがそこまで言うならもうしばらく我慢してもいい
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_01010041")

-- ▼直接出力
PlayPartVoice("フィエナ", "肯定")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:よしよし、いい子だね！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_01010042")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.8)
wait_time(0.3)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:かわいい、か…
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_01010043")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:な、なんだ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_01010045")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("フィエナ", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:ふふーん、フィエナちゃんイイコトをひらめいちゃったかも！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_01010047")

-- ▼直接出力
PlayPartVoice("ガラハッド", "悩む")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガラハッド★★:い、嫌な予感しかしないんだが…
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_01010048")

-- ▼直接出力
CloseTalkWindow()
se_play("SE_ADV_MA_01C111_20_Bell")
wait_time(1.5)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フィエナ", "驚き")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★フィエナ★★:あ、もうこんな時間！？
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_01010050")


	--★★フィエナ★★:なにをひらめいたかは今のところはヒミツってことで！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_01010051")

	PlayAction(Actor003,"to Greet_one")
-- ▼直接出力
PlayPartVoice("フィエナ", "気合い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★フィエナ★★:ノワールにも協力してもらうからね！ヨロシク！
	Talk(Actor003,"CHRNAME_VIENA","speech","L","CO_101028_01010052")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガラハッド", "驚き")
-- ▲直接出力

	--★★ガラハッド★★:ノワールまで巻き込むのか！？　あ、ちょっと姉上！待ってくれ！
	Talk(Actor002,"CHRNAME_GALAHAD","speech","L","CO_101028_01010053")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
PlayActionDirect(Actor003,"to Wlk")
wait_time(0.3)
PlayActionDirect(Actor002,"to Wlk")
wait_time(1.7)
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
wait_time(CHARA_IN_WAIT)
Hide(Actor002)
Hide(Actor003)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + 0.5)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:協力…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101028_01010055")

-- ▼直接出力
local trustParam = set_communication_acquired("ガラハッド_コミュランク", "ガラハッド_親密度")
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
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101028","001","101028001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101036","001","101036001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_05)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
