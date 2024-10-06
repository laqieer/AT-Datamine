-- このluaスクリプトは、MA_01105_26.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110041_01","110041_01_h")
Include("content_adv_advsmall_110041_01","Template110041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110041_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110041_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110041_01,CameraPos110041_01_005)
	InitializeTemplateRandomCamera110041_01()
	InitializeTemplate110041_01()
-- ▼直接出力
load_image("10301006", "content_still_10301006_image", "103010060_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("10301007", "content_still_10301007_image", "103010070_StillImage")
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight(Actor002, 1.2, 0, 0.4, 0.2,1.0)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_delay_weight(Actor001, 1.2, 0, 0.4, 0.2,1.0)
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110041)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:…引き籠ってていい、って言われたの<br>ルーシャス皇太子殿下にね、甘やかされちゃった
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260002")

	change_face(Actor002,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_260003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:だから、出てきた
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260005")

	change_face(Actor002,"Normal")

	--★★ノワール★★:どういう、関係なんだ？<br>ルーシャス皇太子と
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_260006")

	PlayAction(Actor001,"to  Std_Joy")

	--★★ギネヴィア★★:わたしの純情可憐さに<br>一目惚れ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","MA_01105_260009","MA_01105_260010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor002,"Normal")

	--★★ノワール★★:…ふうん
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_260012")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★ノワール★★:純情可憐だもんな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_260013")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:思ってないでしょ！！<br>ジョークよ、クイーンジョーク！！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ノワール★★:心配なんだよ、ギネヴィア
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_260016")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:…ごめんなさい<br>ジョーダン言ってる場合じゃなかったね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:なんか、ありがとう
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260018")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:お戯れでしょうね。はべらせたいのかしら<br>「ローマに連れていってやる」とか言われて
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260020")


	--★★ギネヴィア★★:…迷ったりしたこともあった
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:キャメリアードにいた頃は<br>いつか旅に出られたらいいな…って思ってたケド
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260022")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
 --エフェクト開始
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301006", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ギネヴィア★★:カレドニアからの侵攻が始まって<br>軍備も貧相なキャメリアードに勝ち目、なくて
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01105_260024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:パパがね、国民をログレスに逃がして…託したの<br>で。王女だったわたしの安全を守るには──
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01105_260025")

	change_face(Actor002,"Normal")

	--★★ノワール★★:…ログレス王アーサーとの政略結婚
	Talk(Actor002,"CHRNAME_NOIR","simple","N","MA_01105_260026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:アーサーはわたしを尊重してくれてる<br>いまだに王妃（仮）──婚約者止まりだしね
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01105_260027")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 
--エフェクト終了
hide_image()
 
--スチル終了
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:遠く知らない国に旅立ちたかったのに<br>今はたまらなく帰りたい
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:旅が素晴らしいって思えるのは<br>故郷あってこそなんだって気付いた、なのに…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260030")

	open_select_window_tag(Actor002,"Normal","MA_01105_260031","MA_01105_260032","MA_01105_260033")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	change_face(Actor002,"Normal")

	--★★ノワール★★:きっとまだ、お父さんも生きてるよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_260035")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:そう思う？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ノワール★★:…ああ、思うよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_260037")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:そう。そうだといいよね、本当に
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260039")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	change_face(Actor002,"Normal")

	--★★ノワール★★:これからみんなを<br>救出に行くんだろう？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_260041")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ノワール★★:なのにキミが弱気で<br>どうするんだ？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_260042")

	change_face(Actor002,"Smile")

	--★★ノワール★★:キミが先頭に立って<br>みんなを引っ張っていかなきゃ！
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_260043")

	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:わたしが先頭に立つの？<br>ケイにすら認められていないわたしが？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260044")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	change_face(Actor002,"Normal")

	--★★ノワール★★:なにか俺に出来ることはある？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_260046")

	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:話、聞いててほしい…、ここで
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260047")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ノワール★★:聞くよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_260048")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:ごめんね、ごめんね…<br>でも…ありがとう
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260049")

	goto Block2end

::Block2end::
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
 
 --エフェクト開始
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
show_image("10301007", 0.0, 0.0, 0.0)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:あの日、バルバロイが祭壇に<br>溢れてるのを見た時点でね
	Talk(Actor001,"CHRNAME_GUINEVERE","simple","N","MA_01105_260052")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
 
--エフェクト終了
hide_image()
 
--スチル終了
off_cameraframe()
off_screencolor()
wait_time(IMAGE_TIME_WAIT_AFTER)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力

	--★★ギネヴィア★★:わかってた、本当は
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260054")


	--★★ギネヴィア★★:ケイもアーサーも策を練ってくれてた<br>わたしたちだけじゃどうしようもなかった
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:待つしかないなら、信じてあげようと思った<br>パパは生きてる、だからわたしは平気な顔したの
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260056")


	--★★ギネヴィア★★:バカ騒ぎしたの。学校生活も、五月祭も<br>わたしが平気な顔して着飾っていれば
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260057")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:パパがまだ生きてること<br>信じられるんじゃないかって思ったの
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260058")

	change_face(Actor002,"Sad")

	--★★ノワール★★:まだ、バルバロイにやられたと<br>決まったわけじゃ…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_260059")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:バルバロイってね<br>人に憑くこともあるの
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260060")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:憑りついて、その人の悪しき記憶<br>悪しき想いを増長させて取り込んで
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260061")


	--★★ギネヴィア★★:少しずつその存在を喰っていくの
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260062")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:最初はその人自身の記憶を喰らう<br>喰われた側は自分が誰だかわからなくなってく
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260064")

	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Surprise")

	--★★ノワール★★:…自分が、わからなく…？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_260065")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:それが喰い尽くされるとね──
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260066")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:周りの人間から<br>その存在の記憶が忘れ去られてく
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260067")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
lookat_weight_default(Actor001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:バルバロイになった人のことを<br>周囲の人が忘れていく、ようになる…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260069")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:…！？<br>それって…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_260070")


	--★★ギネヴィア★★:パパとの思い出<br>どんどんなくなってるの
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260071")

	change_face(Actor002,"Sad")

	--★★ノワール★★:…このあいだの…！
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_260072")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネヴィア★★:でも、キャメリアードに<br>帰りたくない自分もいるの…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260073")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★ギネヴィア★★:パパが生きてるって信じ続けたいの…<br>平気な顔、してたいのよ…！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260074")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:現実を見るのが、怖いの…っ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260075")

	PlayAction(Actor001,"to  Std_Sad01")

	--★★ギネヴィア★★:………だけど、忘れたく…ないよ…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_260076")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10301006", "content_still_10301006_image", "103010060_StillImage")
load_image_preload("10301007", "content_still_10301007_image", "103010070_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110041)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
