-- このluaスクリプトは、CO_101065_0802.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_01","112041_01_h")
Include("content_adv_advsmall_112041_01","Template112041_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName112041_01,CameraPos112041_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName112041_01,CameraPos112041_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_01,CameraPos112041_01_004)
	InitializeTemplateRandomCamera112041_01()
	InitializeTemplate112041_01()
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
sakabin = setup_prop_object(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
on_parent(sakabin ,Actor003, "Loc_weapon_constrint_R", sakabin_offset2 )
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Bar")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Sit01_Loop")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:それで、どんな仕事だ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_08020002")

	PlayAction(Actor002,"to Sit01_Loop")
-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力

	--★★キッス★★:前に少し話した<br>子供たち絡みのお仕事よ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020003")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:聞かせてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_08020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:少し前からログレスやロンディニウムで<br>子供がさらわれる事件が続いていてね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020006")


	--★★キッス★★:さらわれる前に助けられた子もいるんだけど<br>何人かは間に合わなかったの
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020008")


	--★★キッス★★:だから、人身売買の現場をおさえて<br>子供たちを助けようと思うのよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020009")

-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:人身売買の日時と場所を<br>つかんだってわけか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_08020010")

-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★キッス★★:そうよ<br>そして、その人さらいというのが…
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★キッス★★:魔女のしもべを自称する<br>バルバロイ信奉者の集団
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★キッス★★:少し前にログレスで噂になっていた連中よ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020014")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:それって…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_08020015")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:恐らく、ラビットちゃんが<br>ケイ卿に調査を頼まれていた集団ね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020016")

	open_select_window_tag(Actor001,"Normal","CO_101065_08020018","CO_101065_08020019")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:行かない理由がないな<br>場所はどこなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_08020021")

-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:頼もしい言葉ね♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020022")

	change_face(Actor002,"Normal")

	--★★キッス★★:でも、あんまりせっかちだと女の子に嫌われちゃうわよ？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020023")

	change_face(Actor002,"Smile")

	--★★キッス★★:落ち着いてお姉さんの話を聞きなさい♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020024")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:バルバロイの信奉者たちはなぜ子供をさらうんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_08020026")

-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:詳しくはわからないけれど
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020027")

	change_face(Actor002,"Normal")

	--★★キッス★★:人間がもつキラーズ因子は年齢とともに減少していくというし
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020028")

	change_face(Actor002,"Sad")

	--★★キッス★★:…バルバロイへの生贄に適しているのかもね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020029")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ますます放っておけないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_08020031")

	goto Block1end

::Block1end::
-- ▼直接出力
bgm_play("BGM_Area_Bar")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:取引される日にはまだ少し猶予があるのそれまでに準備を整えておいてちょうだい
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020033")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それはいいけど…随分詳しいんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_08020034")

-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:確かな情報源があるものキミのお陰で…ね♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020035")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺のお陰…？どういうことだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_08020036")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:ストップ根掘り葉掘り聞かれるのは好きじゃないわ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020037")


	--★★キッス★★:女って束縛を嫌う生き物なの覚えておきなさい、ラビットちゃん
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020038")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:またそうやってはぐらかす…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_08020039")

-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力

	--★★キッス★★:それはそうと、当日はアタシも同行するから護衛よろしくね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020040")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それはもちろんだけどいつものように酒場で待ってればよくないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_08020041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:あら、心配してくれるの？ありがとう
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020043")


	--★★キッス★★:でも心配は無用よこれでも少しは鍛えてるつもりだから♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020044")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうなのか…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_08020045")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:まぁでも、わかった決行日になったらまた来るよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_08020046")

-- ▼直接出力
PlayPartVoice("キッス", "肯定2")
-- ▲直接出力

	--★★キッス★★:待ってるわね～
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_08020047")

-- ▼直接出力
local trustParam = set_communication_rankup("キッス_コミュランク", "キッス_親密度")
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
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
preload_sound("BGM_Area_Bar")
	InitializeLoad_Preload()
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
