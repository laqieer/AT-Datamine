-- このluaスクリプトは、CO_101015_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_01","110051_01_h")
Include("content_adv_advsmall_110051_01","Template110051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-100,CharaPos110051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_003)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110051_01,CameraPos110051_01_002)
	InitializeTemplateRandomCamera110051_01()
	InitializeTemplate110051_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110051)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ケイ★★:まったく、お前というやつは…！
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_10020002")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ケイ★★:一国の王であるにもかかわらず、<br>単身で敵地に向かうなど無茶にもほどがある！
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_10020003")


	--★★ケイ★★:撤退後に動きがなかったところから<br>功を急いだ将校の勇み足の類だったようだが
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_10020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "怒り")
-- ▲直接出力

	--★★ケイ★★:これが敵の作戦のひとつだったら<br>どうするつもりだったのだ！？
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_10020005")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:すまない！<br>だが、一刻を争う事態だったんだ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020006")

	PlayAction(Actor002,"to  Std_Talk")

	--★★アーサー★★:それに単身ってわけじゃないぞ！<br>ノワールも一緒だった！なあ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020007")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ！？<br>あ、ああ…うん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_10020008")

	PlayAction(Actor004,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("マーリン", "落胆")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★マーリン★★:…要するに、ノワール様を巻き込んだ<br>ということですよね
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","CO_101015_10020009")

-- ▼直接出力
PlayPartVoice("アーサー", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★アーサー★★:すみません
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マーリン★★:王と継承者は我らの希望です
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","CO_101015_10020012")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マーリン", "怒り")
-- ▲直接出力

	--★★マーリン★★:安易にその身を危険に晒すべきではないと<br>あなたはおわかりのはず
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","CO_101015_10020013")

	change_face(Actor002,"Normal")

	--★★アーサー★★:…ああ、わかっているとも
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020015")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("マーリン", "否定")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★マーリン★★:ならば――
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","CO_101015_10020016")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力

	--★★アーサー★★:だからといって俺たちの大切なものを<br>見捨てなきゃいけない道理はない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020017")

	PlayAction(Actor002,"to  Std_Talk")

	--★★アーサー★★:少なくとも俺があの時目指した立派な王様は<br>民を見捨てたりなどしない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020018")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:俺は、俺が選んだ王道を往くよ<br>たとえ甘いと言われても
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:王として正しい道ではなくても
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020021")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:アーサー…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_10020023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:それに義兄さんだって<br>結局援軍をよこしてくれたじゃないか
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020024")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ケイ", "否定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ケイ★★:い、いや、それはだな…
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_10020025")

	PlayAction(Actor002,"to  Std_Talk")

	--★★アーサー★★:大急ぎで学園の防備体制を見直して<br>援軍を送る手筈を整えてくれたって聞いたぞ？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020026")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ケイ", "照れ")
-- ▲直接出力

	--★★ケイ★★:私は職務をまっとうしただけだ<br>王が決めたことを支えるのが私の務めだからな
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_10020028")


	--★★ケイ★★:それに…<br>お前がやろうとすることはわかっているつもりだ
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_10020029")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:ああ。さすが義兄さんだ<br>おかげで助かったよ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020030")

	change_face(Actor002,"Normal")

	--★★アーサー★★:勝手に行動したのは悪いと思っている<br>だがそのおかげで村の被害は最小限で済んだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020032")


	--★★アーサー★★:民を守るという王の姿勢を示すことで<br>ログレスの民の信頼を得ることもできた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020033")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:結果として、ログレスの団結に繋がった<br>…どうだ、結果オーライじゃないか！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:それは、そうだが…
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_10020035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:それに…久しぶりに３人で並んで食べた<br>ホットドッグは旨かっただろう？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020036")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ホットドッグ…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_10020037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★ケイ★★:…まぁな
	Talk(Actor003,"CHRNAME_KAY","speech","L","CO_101015_10020039")

-- ▼直接出力
 --時間経過（黒）
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
Hide(Actor003)
Hide(Actor004)
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.7, 0.6} , 1)
keep_ik_lookat(Actor002,Actor001,"J_Head")
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.5, 0.1, 0.8, 0.6} , 1)
keep_ik_lookat(Actor001,Actor002,"J_Head")
setup_small_camera_start()
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力

	--★★アーサー★★:いやあ、久しぶりにこってり絞られたな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101015_10020043","CO_101015_10020044","CO_101015_10020045")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:マーリンさん、怖かったな…<br>怒るとあんな感じなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_10020047")

-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:あの冷たい目でじっと見られると<br>無性に泣きたくなるよな！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020048")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★アーサー★★:だが、本気で怒ったマーリンの迫力は<br>あんなものじゃないぞ？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020049")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そ、そうなのか！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_10020050")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:だからお前もマーリンを怒らせるようなことは<br>絶対にするな。絶対にな…
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020051")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…ケイのやつ、ガミガミ怒ってる割には<br>なんか嬉しそうだったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_10020053")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:義兄さんは根が素直だからな<br>故郷の無事が嬉しいのさ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020054")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:確かに、村の様子を見にきたケイの顔<br>ずいぶんほっとした様子だったもんな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_10020055")

	change_face(Actor002,"Normal")

	--★★アーサー★★:ああ<br>しかしノワールにまで見抜かれているとはな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020056")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:あとで義兄さんに教えてやろう<br>きっと悔しがるぞ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020057")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:孤児院のあの子ども、大丈夫かな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_10020059")

-- ▼直接出力
PlayPartVoice("アーサー", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:精神的ショックは大きかったようだが<br>孤児院の先生方のケアもあって落ち着いたそうだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020060")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★アーサー★★:あそこの先生はみなとても優しいからな<br>きっと大丈夫だ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020061")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そういえば、あんたたち３人で<br>孤児院にあいさつへ行っていたよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_10020062")

	change_face(Actor002,"Surprise")

	--★★アーサー★★:おっと、見られていたのか
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020063")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ。なんか学園とは少し雰囲気が違っていたよ<br>なんていうか、３人とも楽しそうっていうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_10020064")

-- ▼直接出力
PlayPartVoice("アーサー", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:先生方のなかで、俺たちはいつまでも<br>手のかかる子供のままのようでな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020065")

	change_face(Actor002,"Normal")

	--★★アーサー★★:つい俺も童心に戻ってしまったようだ
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020066")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★アーサー★★:…しかし、お前がいなければ<br>こうも上手くはいかなかったかもな
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020068")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★アーサー★★:あの状況で、目線だけで俺の狙いを理解して<br>迷いなく動いてくれた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020069")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺はただ、あんたなら<br>絶対あの子どもを見捨てたりしないって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_10020070")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:そのための行動をとるはずだと思っただけだ<br>確かに、無茶だとは思ったけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_10020071")


	--★★アーサー★★:だが、お前は乗ってくれた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020072")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:お前のように共に無茶をやってくれる<br>友を得られたのは僥倖だ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020073")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:王様が友達、悪くないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_10020075")

	change_face(Actor002,"Normal")

	--★★アーサー★★:…ノワール、お前のおかげで<br>俺は後悔のない選択をすることができた
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020077")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("アーサー", "肯定3")
-- ▲直接出力

	--★★アーサー★★:だから今度は俺がお前の力になると誓おう<br>この先、お前が後悔のない選択ができるよう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020078")


	--★★アーサー★★:…たとえ、なにがあろうとも
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020079")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:アーサー？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101015_10020080")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:うん、落ち着いたら腹が減ってきたな！<br>城下町のB級グルメが食べたい気分だ！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020082")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("アーサー", "喜び")
-- ▲直接出力

	--★★アーサー★★:さっそく食べに行くとしよう！<br>さあ、ノワール！お前もついてこい！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","CO_101015_10020083")

-- ▼直接出力
local trustParam = set_communication_rankup("アーサー_コミュランク", "アーサー_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
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
	load_area_scene_preload(110051)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
