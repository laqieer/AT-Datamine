-- このluaスクリプトは、CO_101001_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-85,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	Camera002 = SetTemplate("Actor002",125,CharaPos110071_04_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_003)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.4,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
-- ▼直接出力
load_image("103050200","content_still_10305020_image","103050200_StillImage")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor001,{0.35,0.125,45})
set_pos(Actor002,{-0.75,0.125,45.3})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:それで？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020002")

-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ティルフィング", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:先ほど、ガウェイン様とラグネル様から<br>試験結果が上々だったと報告がありました
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020004")


	--★★ティルフィング★★:それと、ディナタン様やガレス様<br>リオネス様がですね…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020005")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_start(Camera001)
change_face(Actor001,"Smile")
wait_time(0.3)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうだったのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020006")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:はい！
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020007")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力

	--★★ノワール★★:それにしても…<br>ここまで嬉しそうなキミを見たのは初めてだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020008")

-- ▼直接出力
PlayPartVoice("ティルフィング", "驚き")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ティルフィング★★:そ、そう、だったでしょうか…？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:いいことだと思うぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020011")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0050")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ところで<br>話ってそれだけなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020012")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ティルフィング","swim_0002")
-- ▲直接出力

	--★★ティルフィング★★:実はディナタン様に<br>お誘いをいただいたんです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020013")


	--★★ティルフィング★★:またみんなでマカロンを食べに行こう、と
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020014")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0057")
-- ▲直接出力

	--★★ノワール★★:それ、俺も入ってるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020015")

-- ▼直接出力
setup_small_camera_start(RndCamera090)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:はい、もちろん
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020016")

-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0058")
PlayActionDirect(Actor001,"to  Std_Sad01")
wait_time(0.7)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:また奢らせる気だな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020017")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ティルフィング", "笑い")
-- ▲直接出力

	--★★ティルフィング★★:ふふ、ディナタン様は<br>そのようでしたが
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020018")


	--★★ティルフィング★★:マスターには、今度は私が<br>ごちそうさせていただきます
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0040")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？<br>いや、でも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020020")

	PlayAction(Actor001,"to  Std_No")

	--★★ノワール★★:騎士として<br>女性に奢らせるわけにはいかないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020021")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:いいえ。マスターがなんと言おうと<br>私がごちそういたします
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020022")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:これは、感謝の気持ちですから
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020023")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:感謝って言っても…<br>そもそもそんな大した額じゃなかったから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:額の問題ではありませんし
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020027")

-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:そもそもあのとき奢っていただいた<br>お礼だけではありません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0052")
-- ▲直接出力

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:マスター<br>アナタが私を導いてくださったから
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020031")

	change_face(Actor002,"Smile")

	--★★ティルフィング★★:私はこうして多くの方と交流し<br>楽しいお喋りができるようになりました
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020033")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ティルフィング", "笑い")
-- ▲直接出力

	--★★ティルフィング★★:そんなアナタへ<br>少しでも恩返しさせていただきたいのです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020034")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ティルフィング…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020035")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0038")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:分かった<br>そういうことなら、ごちそうになるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020037")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:はい、約束ですよ
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020039")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera005)
wait_time(1)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:不思議なものですね
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020041")

	change_face(Actor001,"Normal")

	--★★ノワール★★:不思議？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020042")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力

	--★★ティルフィング★★:私はアナタを守るべく<br>この地に降り立ったはずなのに
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020043")

	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:今はアナタやアナタの仲間もみなさんと<br>楽しく笑い、想いを共有している
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020044")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0009")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020046")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:これが、かつての私の選択が<br>もたらした結果なのだとしたら、私は…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020047")

-- ▼直接出力
wait_time(1)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:私は<br>恵まれているのかも知れませんね
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020049")

	open_select_window_tag(Actor001,"Normal","CO_101001_10020051","CO_101001_10020052")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0049")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:「かも」じゃないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020054")

-- ▼直接出力
PlayPartVoice("ティルフィング", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:え？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020055")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:間違いなくキミの選択がもたらしたんだ<br>今のこの関係は、さ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020056")

	change_face(Actor001,"Laugh")

	--★★ノワール★★:キミだけじゃない<br>キミと俺のふたりきりでもない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020057")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:キミの周りにいるみんなが<br>今を楽しいと思っていてくれているはずさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020058")

	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:マスター…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020059")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺もだよ<br>俺も、恵まれてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020061")

	change_face(Actor001,"Smile")

	--★★ノワール★★:こうやってティルフィングと出会い<br>一緒に過ごすことができるんだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020062")

	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:マスター…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020063")

	change_face(Actor001,"Normal")

	--★★ノワール★★:こういうこと言うの<br>ちょっと恥ずかしいけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020065")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:出会えて嬉しいよ<br>ティルフィング
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020066")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:はい、私もです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020068")

	goto Block1end

::Block1end::
	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:新たな出会いがあり<br>そして驚くべき再会もありました
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020070")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:でもやはり私にとっての一番はアナタです<br>マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020071")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020072")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "笑い")
-- ▲直接出力

	--★★ティルフィング★★:アナタはいつも私に寄り添ってくれた<br>それが一番嬉しいことです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020073")


	--★★ノワール★★:ティルフィング…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020074")

-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力

	--★★ティルフィング★★:マスター<br>私はもう寂しくなんてありません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020076")

-- ▼直接出力
PlayPartVoiceDirect("ノワール_008","0052")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020077")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ティルフィング★★:アナタがたくさん<br>新たな思い出をくださいました
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_10020078")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ティルフィング…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_10020079")

-- ▼直接出力
CloseTalkWindow()
show_image("103050200", 0.0, 0.0, IMAGE_TIME_IN_IN,false,true) 
set_scale_image(0.8,0.8) 
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:今、ここにあらためて誓います<br>アナタがご自身の武器を手にするそのときまで
	Talk(Actor002,"CHRNAME_TYRFING","simple","N","CO_101001_10020080")


	--★★ティルフィング★★:私は最初の武器として<br>アナタをお支えします
	Talk(Actor002,"CHRNAME_TYRFING","simple","N","CO_101001_10020081")


	--★★ティルフィング★★:継承者ノワール
	Talk(Actor002,"CHRNAME_TYRFING","simple","N","CO_101001_10020083")

-- ▼直接出力
PlayPartVoice("ティルフィング", "喜び")
-- ▲直接出力

	--★★ティルフィング★★:アナタに出会えて、よかった
	Talk(Actor002,"CHRNAME_TYRFING","simple","N","CO_101001_10020085")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("ティルフィング_コミュランク", "ティルフィング_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("103050200","content_still_10305020_image","103050200_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
