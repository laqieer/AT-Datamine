-- このluaスクリプトは、CO_101039_0503.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110191_04","110191_04_h")
Include("content_adv_advsmall_110191_04","Template110191_04_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110191_04_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110191_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110191_04,CameraPos110191_04_002)
	InitializeTemplateRandomCamera110191_04()
	InitializeTemplate110191_04()
-- ▼直接出力
turn_lookat(Actor001,Actor002,0)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor002,Actor001,0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110191)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:ルーシャスくんだけじゃなく<br>ローラまであんなこと言うなんて…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030002")


	--★★フレン★★:あの子がローマのことを<br>想う気持ちはわかるよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
	change_face(Actor002,"Anger")

	--★★フレン★★:でも、せっかく戻ってこられたのに！<br>今度は学園とローマを往復するだなんて！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101039_05030007","CO_101039_05030008")
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

	--★★ノワール★★:フレン<br>ここは姉として妹の意思を大事にしてあげよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05030010")

-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:えっ？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030011")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:さっきのローラの瞳には<br>強い意志が感じられた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05030012")

	change_face(Actor001,"Normal")

	--★★ノワール★★:きっとローラなりに考えて<br>結論を出したんだと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05030013")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:それはローマだけじゃなくて<br>フレンのことも考えての結論なはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05030014")

-- ▼直接出力
PlayPartVoice("フレン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:ローラは私のことを考えて<br>今回のことを決意した…？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ローラも言ってたろ？<br>今生の別れじゃないんだ、心配いらないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05030017")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それにルーシャスだって<br>女の子ひとりにそんなに無茶はさせないはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05030018")

	change_face(Actor001,"Sad")

	--★★ノワール★★:（…たぶん）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101039_05030019")

-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:ノワールくんがそこまで言うなら…<br>うん、わかった。信じてみるよ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030020")

	goto Block1end

::Block1end::
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★フレン★★:ありがとう、ノワールくん<br>少し落ち着いた
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030022")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:故郷のためになにかしたいっていう<br>ローラの気持ちを尊重してやろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05030023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★フレン★★:うん…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030024")


	--★★フレン★★:私とローラが<br>ローマ生まれだって話、前にしたよね？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030026")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:うん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05030027")

	PlayAction(Actor002,"to  Std_Talk")

	--★★フレン★★:この学園に来る数年前のことなんだけどね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030028")


	--★★フレン★★:私たちの住んでいた村がバルバロイに襲われて<br>たくさんの人が亡くなったの
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
	change_face(Actor002,"Sad")

	--★★フレン★★:そこには私たちと仲の良かった人もいた<br>…たぶん、だけどね
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030030")

	change_face(Actor002,"Normal")

	--★★フレン★★:私とローラ、お母さんは<br>なんとか逃げ出すことができたんだけど
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★フレン★★:どこへ逃げてもバルバロイがいた
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030033")


	--★★フレン★★:お母さんは私たちを守るために<br>頑張って働いてくれたんだけど
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030034")

-- ▼直接出力
PlayPartVoice("フレン", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★フレン★★:頑張りすぎがたたっちゃって…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030035")


	--★★フレン★★:そのあと、私とフレンは<br>ずっと一緒に生きていこうって誓ったの
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030037")

	PlayAction(Actor002,"to  Std_Sad01")

	--★★フレン★★:バルバロイに奪われた命や場所を<br>取り戻すことなんてできなかった
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★フレン★★:だから、ふたりで頑張って<br>ローマのみんなの無念を晴らそうって
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030039")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:だから<br>ふたりでこの学園に入ったの
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そうだったのか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_05030042")


	--★★フレン★★:ローラはローマのために頑張ってる<br>私は？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030044")

	PlayAction(Actor002,"to  Std_Sad02")

	--★★フレン★★:私にはなにができるの…？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_05030045")

-- ▼直接出力
local trustParam = set_communication_rankup("フレン_コミュランク", "フレン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup()
 -- ここまでの上昇値をゲージの変化量に変換
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
	load_area_scene_preload(110191)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110191_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
