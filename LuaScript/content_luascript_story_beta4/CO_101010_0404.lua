-- このluaスクリプトは、CO_101010_0404.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_duelcommonformation01","DuelCommonFormation01_h")
Include("content_adv_advsmall_duelcommonformation01","TemplateDuelCommonFormation01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPosDuelCommonFormation01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPosDuelCommonFormation01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleNameDuelCommonFormation01,CameraPosDuelCommonFormation01_005)
	InitializeTemplateRandomCameraDuelCommonFormation01()
	InitializeTemplateDuelCommonFormation01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_duel_scene(101000011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
-- ▼直接出力
set_battlecontroller(Actor001,"fig_swd","AC_TL_Fig_Swd_Idle_Run","ToAbnormal")
-- ▲直接出力
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:はあ…はあ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040002")

-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:くそ…負けた………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040003")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:バルバロイとの戦いは<br>ただ剣術を磨けばいいというものではない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040004")


	--★★ランスロット★★:バイブス学にキラーズ学、バルバロイ学…<br>授業で得られる知識も必要不可欠だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040005")


	--★★ランスロット★★:知識と技術、その両輪が揃って<br>初めて奴らに対抗できるようになる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040006")

-- ▼直接出力
setup_small_camera_start(Camera002)
set_animationcontroller(Actor001, "Chr_002_01_StdController", "to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:まずはしっかり、基礎を学べ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:はあ～…<br>ちょっとくらいはいけると思ったのに…くそ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040009")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:ふ、相変わらず負けず嫌いだな、お前は
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040011")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040012")

-- ▼直接出力
PlayPartVoice("ランスロット", "喜び")
-- ▲直接出力

	--★★ランスロット★★:昔もそうやって<br>俺に負けるたびに悔しそうにしていた
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040014")

-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:覚えてなくていいんだよ、そういうことは
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040016")

	change_face(Actor001,"Sad")

	--★★ノワール★★:このあいだのトマトといい、今回といい…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんであんたはそう<br>余計なことばかり覚えてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040019")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:俺にとっては余計なことではない<br>すべて大切な思い出だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ランスロット…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040021")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:お前やディナタンを置いて<br>ひとりログレスへ来たことは
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040023")


	--★★ランスロット★★:正直に言って<br>今でも正しい選択だったかと自問自答する
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040024")

-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:だからだろうか<br>あの頃と変わらないお前の姿を見ると安心するな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ランスロット★★:いなくなった俺のことを<br>お前はきっと怒っているだろうがな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101010_04040029","CO_101010_04040030")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:当たり前だろ…怒ってるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040032")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ああ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040033")

	change_face(Actor001,"Normal")

	--★★ノワール★★:勝手にいなくなって<br>勝手に最強騎士なんて言われて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ああ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040035")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ディナタンも泣いてた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040036")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:ああ…すまない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040038")

	change_face(Actor001,"Normal")

	--★★ノワール★★:けど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040039")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:怒ってないさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040041")

-- ▼直接出力
PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:本当か？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040042")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そりゃ、いなくなったばかりのときは<br>当然怒ってたけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040043")

	change_face(Actor001,"Normal")

	--★★ノワール★★:今は…そうでもない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040044")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:そうか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040045")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたを追ってここまで来て<br>あの頃には知らなかったいろんなことを知った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040047")

	change_face(Actor001,"Sad")

	--★★ノワール★★:まだわからないこともたくさんあるけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040048")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:今こうして一緒にいられること自体は<br>悪くないと感じ始めてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ランスロット", "照れ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ノワール…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040050")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:再会したばかりの頃は恨む気持ちもあったけど…<br>今はもうないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040052")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:思ってた以上に<br>ランスロットはランスロットのままだったしな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040053")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:まあ、勝てないところまで<br>昔のままなのは悔しいけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040054")

-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:ふっ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040056")


	--★★ランスロット★★:安心しろ。確かに今回は俺の勝ちだったが<br>お前だってちゃんと成長している
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040057")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:剣の腕は正直見違えた<br>言うだけのことはある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040058")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:本当か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_04040059")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:本当だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040060")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:同じ師の下で学んだんだ<br>お前の素質の高さは俺もよく知ってる
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040062")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:強くなれる、お前は<br>…今よりももっと、な
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_04040063")

-- ▼直接出力
local trustParam = set_communication_rankup("ランスロット_コミュランク", "ランスロット_親密度")
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
	InitializeLoad_Preload()
	load_duel_scene_preload(101000011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleNameDuelCommonFormation01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
