-- このluaスクリプトは、MA_01A110_42.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110251_31","110251_31_h")
Include("content_adv_advsmall_110251_31","Template110251_31_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110251_31_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110251_31,CameraPos110251_31_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110251_31_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110251_31,CameraPos110251_31_002)
	InitializeTemplateRandomCamera110251_31()
	InitializeTemplate110251_31()
-- ▼直接出力
lookoj = create_object("kara")
set_pos_object(lookoj,0.136,2.232,18)
-- ▲直接出力
-- ▼直接出力
BgProp = setup_prop_object(10102023)
set_pos(BgProp,{0,0,0})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115254)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力

	--★★ギネヴィア★★:「あなたが隣にいる。それだけでこの困難も<br>たやすく乗り越えていける気がします」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420002")


	--★★ギネヴィア★★:「ひとつ誓いを立ててもらえますか？」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:………えーっと
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A110_420004")


	--★★ギネヴィア★★:…「な」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420005")

	change_face(Actor002,"Surprise")

	--★★ノワール★★:な？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A110_420006")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:「なん」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420007")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:「なん」…？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A110_420008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "激怒")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:次のあなたの台詞！！<br>「なんなりと」！！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420009")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:ちゃんと承りなさいよぉ継承者ぁ～
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:終わったら木の衣装あげるから<br>がんばってよぉ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420011")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:かさばるな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A110_420012")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:いいでしょ？<br>片づけづらくって
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420013")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネヴィア★★:ソレを見るたびに舞台のこと思い出すのよ<br>ベッドサイドにでも置いといてね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420014")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:台詞…完璧だな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A110_420015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:ハンパなもの、見せたくないもん
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420017")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:<ruby=マルディサント>演出家</ruby>が言ってた<br>「<ruby=ギネヴィア>自分</ruby>しか持ってないモノ」
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A110_420018")


	--★★ノワール★★:…ってわかったのか？そういえば
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A110_420064")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:…にっしっし。さあね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:心配は…なさそうだけど
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A110_420022")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:…勝手にさ、王妃を降りてさ<br>ちょっとしたスキャンダルだったわけでしょ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420024")

-- ▼直接出力
PlayActionDirect(Actor001,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:ね、みんな拍手してくれるかな<br>もと王妃にも
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor002,"Normal","MA_01A110_420027","MA_01A110_420028","MA_01A110_420029")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:あたりまえだろ<br>みんな、ギネヴィアの頑張りを知ってる
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A110_420031")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
 --PlayPartVoice("ギネヴィア", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:がんばるだけじゃ…<br>ダメなこともあるじゃん
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420032")

-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:今はギネヴィアが誰であるかを<br>飾る必要なんてないよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A110_420033")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:…まあ、ね<br>あなたに選んでもらったんだもんね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420035")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:どうかな…<br>もと王妃に向けての拍手はないかもな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A110_420037")

	PlayAction(Actor001,"to HoldHead")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:ぎゃー！無慈悲なコトバ！やさしくしてよ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420038")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:でも、今のギネヴィアへの称賛は<br>拍手となって返ってくるさ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A110_420039")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:そのぉ、その『今の』わたしがさぁ<br>ちゃんとできてないといけないわけでしょお…？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420040")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ノワール★★:結果はどうあれ<br>俺はギネヴィアに拍手を送るよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A110_420042")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:あなたは舞台上でなんの役割？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420043")

-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:え…木だよ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A110_420044")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:木は拍手できないでしょお…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420045")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:そうだ<br>俺、木だった…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A110_420046")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:私…なにひとつ演じる必要もない<br>特別になれた、してもらえたの
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420048")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:それが本当に嬉しかった
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420050")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:ノワールのために、学園のみんなのために<br>世界のためにわたしは生きられている
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420051")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:これってすごいことだよ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420052")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:…そうだな
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A110_420053")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:だから<br>飾らないありのままのわたしを舞台に上げる
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420054")


	--★★ギネヴィア★★:それが一番<br>みんなに伝わるかなって思うんだ
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001, lookoj, "kara")
lookat_weight(Actor001, {0.8, 0.2, 0.8, 0.5})
keep_delay_ik_lookat_object(Actor001,lookoj,"kara",0.5)
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力

	--★★ギネヴィア★★:苦しいことも<br>ずっとは続かないはずだよって
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420057")

	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:楽観的かもしれないけど
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420058")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:頑張ったら<br>報われるんだよって
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420059")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力

	--★★ギネヴィア★★:まだ──…きっとだいじょうぶだよって
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420060")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookat_delay_weight(Actor002, {1.2, 0.1, 0.5, 0.5} ,0.5)
keep_ik_lookat(Actor002,Actor001,"J_Head")
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ノワール★★:…ギネヴィア？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01A110_420061")

-- ▼直接出力
CloseTalkWindow()
lookat_delay_weight_reset(Actor001 , 0.6)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,180,0.5)
slidemove(Actor001,{-0.8,1.21,17}, 2)
wait_time(2.0)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:そう信じられる世界にしなきゃ<br>ちょっと心細いもんね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A110_420063")

-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102023)
	InitializeLoad_Preload()
	load_area_scene_preload(115254)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110251_31)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
