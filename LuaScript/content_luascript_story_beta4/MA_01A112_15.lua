-- このluaスクリプトは、MA_01A112_15.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-80,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	Camera003 = SetTemplate("Actor003",-5,CharaPos110051_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_006)
	Camera004 = SetTemplate("Actor004",-55,CharaPos110051_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_008)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_001)
	Camera006 = SetTemplate("Actor006",130,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
-- ▼直接出力
load_image("102030050_StillImage", "content_still_10203005_image", "102030050_StillImage")
DontChangeRandomCamera(true)
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115054)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01A112_151001")


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01A112_151002")


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01A112_151003")


	--★★テロップ★★:
	Talk(Actor007,"telop","narration","N","MA_01A112_151004")

-- ▼直接出力
CloseTalkWindow()
hide_image(BLACK_WHITE_TIME)
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
	PlayAction(Actor005,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("アーサー", "挨拶")
-- ▲直接出力

	--★★アーサー★★:急に招集をかけてすまない<br>緊急の事態であるがゆえな
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_150002")

-- ▼直接出力
CloseTalkWindow()
show_image("102030050_StillImage", 0.0, 0.0, STILL_SWITCH_TIME ,false,false)
wait_time(STILL_SWITCH_TIME + STILL_ACTIVE_AFTER)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:ルーシャスのいるカレドニアに動きがあった<br>どうやら兵や民が逃げ出しているらしい
	Talk(Actor005,"CHRNAME_ARTHUR","simple","N","MA_01A112_150003")

-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★知将ケイ★★:ログレスに向かうその亡命者の何人かが<br>キャメリアード国跡地に逃げ込んだ
	Talk(Actor006,"CHRNAME_KAY","simple","N","MA_01A112_150004")


	--★★知将ケイ★★:それを追ってローマ軍──バルバロイの軍勢が<br>同じくキャメリアードへ入らんとしている
	Talk(Actor006,"CHRNAME_KAY","simple","N","MA_01A112_150005")

-- ▼直接出力
CloseTalkWindow()
hide_image(STILL_SWITCH_TIME)
wait_time(STILL_SWITCH_TIME + STILL_PASSIVE_AFTER )
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:…亡き我が母国でなんとまぁ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_150006")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:アントニヌス・ウォールを越えて<br>こんな速度で進軍して来れんのかよ…！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_150007")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力

	--★★トリスタン★★:でもさ…亡命者を追うのに<br>そんなに大げさに動く？
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01A112_150008")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "否定")
-- ▲直接出力

	--★★知将ケイ★★:それはついでなのだろう<br>本当の目的は──
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01A112_150009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01A112_150011","MA_01A112_150012","MA_01A112_150013")
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
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:学園、だろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_150015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:スノードンで弱ったわたしたちを<br>早めに叩こうってこと…当たり前よね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_150016")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("トリスタン", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★トリスタン★★:…バルバロイの数は底なしだね<br>ボク僕らにキズを治すヒマすら与えてくれない
	Talk(Actor004,"CHRNAME_TRISTAN","speech","L","MA_01A112_150017")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キャメリアード跡の領地かな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_150019")

	play_head_motion(Actor006, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "否定")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★知将ケイ★★:滅びた国の土地に<br>大軍勢で入る道理がない
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01A112_150020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:キャメリアードを足がかりに<br>学園に攻め込もうという狙いでしょうね…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_150021")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:亡命者の粛清だろうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_150023")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:わざわざ軍を動かしてまですることかあ？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_150024")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★アーサー★★:キャメリアードを足がかりに<br>学園に攻め込もうという狙いだろうな
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_150025")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★知将ケイ★★:その隊を率いるのが――
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01A112_150027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Serious")

	--★★ガウェイン★★:ヴェルナルス…だな
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_150028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("アーサー", "悩む")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★アーサー★★:ルーシャスはまだカレドニア城を動いていない<br>ヴェルナルスによほどの信を置いているのか
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_150030")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★知将ケイ★★:あるいはヴェルナルスが敗れても<br>自らのみでどうにかなるという自信の表れか…
	Talk(Actor006,"CHRNAME_KAY","speech","L","MA_01A112_150031")


	--★★アーサー★★:聖杯をローマより奪取し<br>継承者によるバルバロイの殲滅を叶えるべく──
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_150032")


	--★★アーサー★★:俺たちはカレドニア進軍に向けて<br>準備を進めなければならない
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_150033")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:ノワール、ギネヴィア、ガウェイン<br>お前たちに頼むことはシンプルだ
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_150034")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺の故郷に攻め込む際の憂いを断つ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A112_150035")

	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "激怒")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ギネヴィア★★:わたしの実家に居座るであろう<br>ローマとバルバロイを１一匹残らず叩き出す…
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_150037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★アーサー★★:決行の日は追って通達する
	Talk(Actor005,"CHRNAME_ARTHUR","speech","L","MA_01A112_150039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:なるはやでね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A112_150040")

	PlayAction(Actor003,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ガウェイン★★:…ケリつけてやる
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A112_150041")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("102030050_StillImage", "content_still_10203005_image", "102030050_StillImage")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115054)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
